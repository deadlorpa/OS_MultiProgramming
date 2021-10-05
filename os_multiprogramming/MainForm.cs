using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace os_multiprogramming
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        TaskQueqe taskQueqe;
        bool isRunning = false;
        bool canStop = true;
        DateTime start;

        TimeSpan span;
        int runningTask = -1;

        static string defaultDumpPath = "C:\\Users\\Public\\MyDumps\\";

        public MainForm()
        {
            if (!System.IO.Directory.Exists(defaultDumpPath))
                System.IO.Directory.CreateDirectory(defaultDumpPath);

            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = 
                new ColorScheme(Primary.Orange700, Primary.Orange900, Primary.Orange500, Accent.Red700, TextShade.WHITE);
            workTimer.Enabled = false;
            workTimer.Interval = GlobalVars.PROCESSOR_TICK;
            taskQueqe = new TaskQueqe();

            textboxDurationIO.Text = GlobalVars.MAXIMUM_DURATION_IO.ToString();
            textboxDurationTask.Text = GlobalVars.MAXIMUM_DURATION.ToString();
            textboxProbTask.Text = (100*GlobalVars.PROBABILITY_NEW_TASK).ToString() + '%';
            textboxProbIO.Text = (100*GlobalVars.PROBABILITY_IO).ToString() + '%';
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                chartProc.Series[0].Points.Clear();
                textboxTimeWork.Text = "0:0:0";
                buttonStart.UseAccentColor = true;
                buttonStart.Text = "Стоп";
                isRunning = true;
                start = DateTime.Now;
                workTimer.Enabled = true;
                textboxAvgTimeComplete.Text = "Не посчитано";
            }
            else
            {
                if (canStop)
                {
                    workTimer.Enabled = false;
                    buttonStart.UseAccentColor = false;
                    buttonStart.Text = "Старт";
                    isRunning = false;
                    textboxTimeWork.Text = span.Hours.ToString() + ':' + span.Minutes.ToString() + ':' + span.Seconds.ToString();
                    foreach (MyTask task in taskQueqe.tasksInWork.ToArray())
                    {
                        if (task.getState() == GlobalVars.TaskStates.COMPLETE)
                        {
                            taskQueqe.tasksCompleted.Add(task);
                            taskQueqe.tasksInWork.Remove(task);
                            Tuple<int, int> tuple = task.getProcTimesInfo();
                            updateChart(new DataPoint(tuple.Item1, tuple.Item2));
                        }
                    }
                    textboxTaskComplete.Text = taskQueqe.tasksCompleted.Count().ToString();
                    textboxAllTasks.Text = (taskQueqe.tasksInWork.Count() + taskQueqe.tasksCompleted.Count()).ToString();
                    int avgTime = 0;
                    int n = taskQueqe.tasksCompleted.Count();
                    foreach (MyTask task in taskQueqe.tasksCompleted.ToArray())
                    {
                        avgTime += task.getTimeLive();
                    }
                    if (n > 0)
                        textboxAvgTimeComplete.Text = (avgTime /= n).ToString();
                    else
                        textboxAvgTimeComplete.Text = "Нет выполненых задач :(";
                    dump();
                    taskQueqe.tasksInWork.Clear();
                    taskQueqe.tasksCompleted.Clear();
                    runningTask = -1;
                }
            }

        }

        async private void workTimer_Tick(object sender, EventArgs e)
        {
            workTimer.Enabled = false;
            canStop = false;

            lock (taskQueqe.tasksInWork)
            {
                if (runningTask != -1)
                    if (taskQueqe.tasksInWork[runningTask].getState() == GlobalVars.TaskStates.IO)
                        runningTask = -1;

               
                foreach (MyTask task in taskQueqe.tasksInWork.ToArray())
                {
                    // состояние в/в
                    if (task.getState() == GlobalVars.TaskStates.IO)
                    {
                        task.io();
                    }
                }
                int i = 0;
                foreach (MyTask task in taskQueqe.tasksInWork.ToArray())
                {
                    // состояние завершения
                    if (task.getState() == GlobalVars.TaskStates.COMPLETE)
                    {
                        if (runningTask == i)
                            runningTask = -1;
                        taskQueqe.tasksCompleted.Add(task);
                        taskQueqe.tasksInWork.RemoveAt(i);
                        Tuple<int, int> tuple = task.getProcTimesInfo();
                        updateChart(new DataPoint(tuple.Item1, tuple.Item2));
                        i -= 1;
                    }
                    i += 1;
                }
                i = 0;
                foreach (MyTask task in taskQueqe.tasksInWork.ToArray())
                {
                    // состояние ожидания
                    if (taskQueqe.tasksInWork[i].getState() == GlobalVars.TaskStates.WAIT)
                    {
                        if (runningTask == -1)
                        {
                            runningTask = i;
                        }
                        if (runningTask > i)
                        {
                            task.setState(GlobalVars.TaskStates.WAIT);
                            runningTask = i;

                        }
                    }
                }
            }

            if(runningTask != -1)
                taskQueqe.tasksInWork[runningTask].run();

            await Task.Run(() => taskNew());
            span = DateTime.Now.Subtract(start);
            textboxTimeWork.Text = span.Hours.ToString() + ':' + span.Minutes.ToString() + ':' + span.Seconds.ToString();
            textboxTaskComplete.Text = taskQueqe.tasksCompleted.Count().ToString();
            textboxAllTasks.Text = (taskQueqe.tasksInWork.Count() + taskQueqe.tasksCompleted.Count()).ToString();

            workTimer.Enabled = true;
            canStop = true;
        }

        private void taskNew() // случайное возникновение новой задачи
        {
            lock (taskQueqe.tasksInWork)
            {
                Random rnd = new Random();
                if (rnd.NextDouble() <= GlobalVars.PROBABILITY_NEW_TASK)
                {
                    MyTask task = new MyTask();
                    taskQueqe.tasksInWork.Add(task);
                }
            }
        }

        private void updateChart(DataPoint dp)
        {
            dp.Color = materialSkinManager.ColorScheme.AccentColor;
            chartProc.Series[0].Points.Add(dp);
        }

        private void dump()
        {
            string filename = defaultDumpPath + "dump_" + 
                DateTime.Now.Day.ToString() + '-' +
                DateTime.Now.Month.ToString() + '-' +
                DateTime.Now.Year.ToString() + '_' +
                DateTime.Now.Hour.ToString() + '.' +
                DateTime.Now.Minute.ToString() + '.' +
                DateTime.Now.Second.ToString() +
                ".txt";
            using (var sw = new StreamWriter(filename))
            {
                sw.WriteLine("Выполненные процессы:\n");
                sw.WriteLine("\tпорождён\t|       состояние       |расчетное время|осталось времени|\tвремя выполнения\t|\tI/O");
                foreach (MyTask task in taskQueqe.tasksCompleted)
                {
                    sw.WriteLine(task.getDumpInfo());
                }
                sw.WriteLine("\nНе выполненные процессы:\n");
                sw.WriteLine("\tпорождён\t|    состояние  |расчетное время|осталось времени|\tвремя выполнения\t|\tI/O");
                foreach (MyTask task in taskQueqe.tasksInWork)
                {
                    sw.WriteLine(task.getDumpInfo());
                }
            }
        }
    }
}

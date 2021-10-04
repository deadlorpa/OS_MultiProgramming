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

namespace os_multiprogramming
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        TaskQueqe taskQueqe;
        bool isRunning = false;
        DateTime start;
        TimeSpan span;
        int runningTask = -1;

        public MainForm()
        {
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
            textboxProbIO.Text = GlobalVars.PROBABILITY_IO.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                buttonStart.UseAccentColor = true;
                buttonStart.Text = "Стоп";
                isRunning = true;
                start = DateTime.Now;
                workTimer.Enabled = true;
            }
            else
            {
                workTimer.Enabled = false;
                buttonStart.UseAccentColor = false;
                buttonStart.Text = "Старт";
                isRunning = false;
                textboxTimeWork.Text = span.Hours.ToString() + ':' + span.Minutes.ToString() + ':' + span.Seconds.ToString();
            }

        }

        async private void workTimer_Tick(object sender, EventArgs e)
        {
            workTimer.Enabled = false;
            
            lock (taskQueqe.tasksInWork)
            {
                if (runningTask != -1)
                    if (taskQueqe.tasksInWork[runningTask].getState() == GlobalVars.TaskStates.IO)
                        runningTask = -1;

                int i = 0;
                foreach(MyTask task in taskQueqe.tasksInWork.ToArray())
                {
                    // состояние ожидания
                    if(taskQueqe.tasksInWork[i].getState() == GlobalVars.TaskStates.WAIT)
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
                    // состояние в/в
                    if(task.getState() == GlobalVars.TaskStates.IO)
                    {
                        task.io();
                    }
                    // состояние завершения
                    if (task.getState() == GlobalVars.TaskStates.COMPLETE)
                    {
                        if (runningTask == i)
                            runningTask = -1;
                        taskQueqe.tasksCompleted.Add(task);
                        taskQueqe.tasksInWork.RemoveAt(i);
                        
                    }
                    i += 1;
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
    }
}

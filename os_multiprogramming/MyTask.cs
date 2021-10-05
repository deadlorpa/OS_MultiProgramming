using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_multiprogramming
{   
    public class MyTask
    {
        GlobalVars.TaskStates state;
        int durationIO;
        int duration;
        int reservedDuration;
        DateTime born;
        DateTime complete;
        List<int> listDurationIO; 

        public MyTask()
        {
            state = GlobalVars.TaskStates.WAIT;
            Random rnd = new Random();
            duration = rnd.Next(1, GlobalVars.MAXIMUM_DURATION) * GlobalVars.PROCESSOR_TICK;
            reservedDuration = duration;
            durationIO = 0;
            born = DateTime.Now;
            listDurationIO = new List<int>();
        }
        public void io()
        {
            durationIO -= GlobalVars.PROCESSOR_TICK;
            if (durationIO == 0)
            {
                state = GlobalVars.TaskStates.WAIT;
            }
        }
        public void run()
        {
            state = GlobalVars.TaskStates.RUN;
            duration -= GlobalVars.PROCESSOR_TICK;
            if (duration == 0)
            {
                state = GlobalVars.TaskStates.COMPLETE;
                complete = DateTime.Now;
                return;
            }
            Random rnd = new Random();
            if (rnd.NextDouble() >= GlobalVars.PROBABILITY_IO)
            {
                durationIO = rnd.Next(1, GlobalVars.MAXIMUM_DURATION_IO) * GlobalVars.PROCESSOR_TICK;
                listDurationIO.Add(durationIO);
                state = GlobalVars.TaskStates.IO;
            }
                        
        }
        public GlobalVars.TaskStates getState()
        {
            return state;
        }
        public void setState(GlobalVars.TaskStates taskStates)
        {
            state = taskStates;
        }

        public Tuple<int, int> getProcTimesInfo()
        {
            TimeSpan tp = complete - born;
            int iodur = 0;
            foreach(int i in listDurationIO)
            {
                iodur += i/GlobalVars.PROCESSOR_TICK;
            }
            return new Tuple<int, int>(iodur, (int)tp.TotalSeconds);
        }

        public int getTimeLive()
        {
            TimeSpan tp = complete - born;
            return (int)tp.TotalSeconds;
        }

        public string getDumpInfo()
        {
            string info = "";
            info += "\t"+ born.ToString() + "\t: ";
            info += "|\t" + state.ToString() + "\t: ";
            info += "|\t" + (reservedDuration / GlobalVars.PROCESSOR_TICK).ToString() + "\t: ";
            info += "|\t" + (duration / GlobalVars.PROCESSOR_TICK).ToString() + "\t: ";

            if (listDurationIO.Count() > 0)
            {
                info += "|\t";
                foreach (int i in listDurationIO)
                {
                    info += (i / GlobalVars.PROCESSOR_TICK).ToString() + ' ';
                }
                info+= "\t: ";
            }
            else
            {
                info += "|\tне зарегистрировано I/O\t: ";
            }
            return info;
        }
    }
}

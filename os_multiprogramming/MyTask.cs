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
            duration = rnd.Next(2, GlobalVars.MAXIMUM_DURATION) * GlobalVars.PROCESSOR_TICK;
            reservedDuration = duration;
            durationIO = 0;
            born = DateTime.Now;
            listDurationIO = new List<int>();
        }
        public bool io()
        {
            durationIO -= GlobalVars.PROCESSOR_TICK;
            if (durationIO == 0)
            {
                state = GlobalVars.TaskStates.WAIT;
                return true;
            }
            return false;
        }
        public bool run()
        {
            duration -= GlobalVars.PROCESSOR_TICK;
            if (duration == 0)
            {
                state = GlobalVars.TaskStates.COMPLETE;
                complete = DateTime.Now;
                return false;
            }
            Random rnd = new Random();
            if (rnd.NextDouble() <= GlobalVars.PROBABILITY_IO)
            {
                durationIO = rnd.Next(1, GlobalVars.MAXIMUM_DURATION_IO) * GlobalVars.PROCESSOR_TICK;
                listDurationIO.Add(durationIO);
                state = GlobalVars.TaskStates.IO;
                return true;
            }
            return false;
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

        public string getDumpInfo(bool log)
        {
            string info = "";
            info += born.ToString() + "\t";
            info += "|\t" + state.ToString() + "\t";
            info += "|\t" + (reservedDuration / GlobalVars.PROCESSOR_TICK).ToString() + "c\t";
            info += "|\t" + (duration / GlobalVars.PROCESSOR_TICK).ToString() + "c\t";
            if(state == GlobalVars.TaskStates.COMPLETE)
            {

                info += "|\t" + complete.ToString() + "\t";
            }
            else
            {
                info += "|\t---------------------\t";
            }
            if (log)
            {
                if(durationIO > 0)
                    info += "|\t" + durationIO.ToString() + "\t"; 
                else
                    info += "|\tне зарегистрировано I/O\t";
            }
            else
            {
                if (listDurationIO.Count() > 0)
                {
                    info += "|\t";
                    foreach (int i in listDurationIO)
                    {
                        info += (i / GlobalVars.PROCESSOR_TICK).ToString() + "с ";
                    }
                    info += "\t";
                }
                else
                {
                    info += "|\tне зарегистрировано I/O\t";
                }
            }
            return info;
        }
    }
}

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
        DateTime born;
        DateTime complete;
        public MyTask()
        {
            state = GlobalVars.TaskStates.WAIT;
            Random rnd = new Random();
            duration = rnd.Next(1, GlobalVars.MAXIMUM_DURATION) * GlobalVars.PROCESSOR_TICK;
            durationIO = 0;
            born = DateTime.Now;
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
    }
}

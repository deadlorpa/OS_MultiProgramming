using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_multiprogramming
{
    public static class GlobalVars
    {
        public static int MAXIMUM_DURATION = 20;  // секунды
        public static int MAXIMUM_DURATION_IO = 6; // секунды
        public static int PROCESSOR_TICK = 1000;
        public static double PROBABILITY_IO = 0.2;
        public static double PROBABILITY_NEW_TASK = 0.6;
        public enum TaskStates { RUN, WAIT, COMPLETE, IO };
    }
}

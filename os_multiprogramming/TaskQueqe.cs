using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_multiprogramming
{
    public class TaskQueqe
    {
        public List<MyTask> tasksInWork;
        public List<MyTask> tasksCompleted;
        
        public TaskQueqe()
        {
            tasksInWork = new List<MyTask>();
            tasksCompleted = new List<MyTask>();
        }
    }
}

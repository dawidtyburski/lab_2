using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class task
    {
        private string name;
        private taskStatus status;
        public string Name;
        public taskStatus Status;

        public task(string n, taskStatus s)
        {
            Name = n;
            Status = s;
        }
    }
}

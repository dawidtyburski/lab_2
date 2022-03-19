using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class student : persons
    {
        protected string group;
        public string Group;

        List<task> tasks = new List<task>();

        public student(string n, int a, string g) : base(n, a)
        {
            this.group = g;
        }

        public void AddTask(string n, taskStatus s)
        {
            task t = new task(n, s);
            tasks.Add(t);
        }

        public void UpdateTask(int l, taskStatus s)
        {          
            tasks[l] = new task(tasks[l].Name, s);
        }
    }
}

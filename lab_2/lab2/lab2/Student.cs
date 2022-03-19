using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Student : Person
    {
        protected string group;
        protected List<Task> tasks;
        public string Group { get; set; }

        Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;

        }

        Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public override string ToString() => $"{group}";

        //public void AddTask(string taskName, TaskStatus taskStatus)
        //{
        //    //tasks.Add(taskName);
        //}

        public void RemoveTask(int index)
        {

        }

        public void UpdateTask(int index, TaskStatus taslStatus)
        {

        }

        //public string RenderTasks(string prefix = "\t")
        //{
            
        //}

        //private bool SequenceEqual(List<T> a, List<T> b)
        //{
            
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public abstract class Robot
    {
        private readonly List<Task> tasks = new List<Task>();

        public string Name { get; set; }

        public Robot(string name)
        {
            this.Name = name;
            CreateTasks();
        }

        public Robot()
        {
            CreateTasks();
        }

        //Factory method
        public abstract void CreateTasks();

        public List<Task> Tasks => tasks;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class Quadrupedal : Robot
    {
        public Quadrupedal(string name) : base(name)
        {
        }

        public override void CreateTasks()
        {
            Tasks.Add(new Task("make a sammich", 7000));
            Tasks.Add(new Task("rake the leaves", 18000));
            Tasks.Add(new Task("mow the lawn", 20000));
            Tasks.Add(new Task("bake some cookies", 8000));
            Tasks.Add(new Task("do the laundry", 10000));
        }
    }
}

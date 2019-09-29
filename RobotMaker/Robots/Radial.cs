using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class Radial : Robot
    {
        public Radial(string name) : base(name)
        {
        }

        public override void CreateTasks()
        {
            Tasks.Add(new Task("do the dishes", 1000));
            Tasks.Add(new Task("take out the recycling", 4000));
            Tasks.Add(new Task("mow the lawn", 20000));
            Tasks.Add(new Task("wash the car", 20000));
            Tasks.Add(new Task("give the dog a bath", 14500));
        }
    }
}

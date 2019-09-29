using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class Aeronautical : Robot
    {
        public Aeronautical(string name) : base(name)
        {
        }

        public override void CreateTasks()
        {
            Tasks.Add(new Task("sweep the house", 3000));
            Tasks.Add(new Task("rake the leaves", 18000));
            Tasks.Add(new Task("wash the car", 20000));
            Tasks.Add(new Task("give the dog a bath", 14500));
            Tasks.Add(new Task("make a sammich", 7000));
        }
    }
}

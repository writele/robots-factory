using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class Bipedal : Robot
    {
        public Bipedal(string name) : base(name)
        {
        }

        public override void CreateTasks()
        {
            Tasks.Add(new Task("do the dishes", 1000));
            Tasks.Add(new Task("take out the recycling", 4000));
            Tasks.Add(new Task("sweep the house", 3000));
            Tasks.Add(new Task("do the laundry", 10000));
            Tasks.Add(new Task("wash the car", 20000));
        }
    }
}

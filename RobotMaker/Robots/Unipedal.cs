using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class Unipedal : Robot
    {
        public Unipedal(string name) : base(name)
        {
        }

        public override void CreateTasks()
        {
            Tasks.Add(new Task("do the dishes", 1000));
            Tasks.Add(new Task("take out the recycling", 4000));
            Tasks.Add(new Task("make a sammich", 7000));
            Tasks.Add(new Task("bake some cookies", 8000));
            Tasks.Add(new Task("do the laundry", 10000));
        }
    }
}

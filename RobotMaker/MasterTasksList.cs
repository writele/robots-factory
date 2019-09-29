using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class MasterTasksList
    {
        private readonly List<Task> tasks = new List<Task>();
        public List<Task> Tasks => tasks;
        public void CreateMasterTaskList()
        {
            Tasks.Add(new Task("do the dishes", 1000));
            Tasks.Add(new Task("sweep the house", 3000));
            Tasks.Add(new Task("do the laundry", 10000));
            Tasks.Add(new Task("take out the recycling", 4000));
            Tasks.Add(new Task("make a sammich", 7000));
            Tasks.Add(new Task("mow the lawn", 20000));
            Tasks.Add(new Task("rake the leaves", 18000));
            Tasks.Add(new Task("give the dog a bath", 14500));
            Tasks.Add(new Task("bake some cookies", 8000));
            Tasks.Add(new Task("wash the car", 20000));
        }

        public MasterTasksList()
        {
            CreateMasterTaskList();
        }
    }
}

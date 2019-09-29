using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public class Task
    {
        public Task(string description, int eta)
        {
            this.Description = description;
            this.Eta = eta;
        }

        public string Description { get; set; }
        public int Eta { get; set; }
    }
}

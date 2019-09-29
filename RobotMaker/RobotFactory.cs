using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMaker
{
    public static class RobotFactory
    {
        public static void DisplaySelections()
        {
            Console.WriteLine("Please enter the letter for the robot you wish to build:");
            Console.WriteLine("Enter 'U' for Unipedal, 'B' for Bipedal, 'Q' for Quadrupedal, 'A' for Arachnid, 'R' for Radial or 'Ae' for Aeronautical.");
        }

        public static Robot Build(string robotSelection, string name)
        {
            switch(robotSelection.ToLower())
            {
                case "u":
                    return new Unipedal(name);
                case "b":
                    return new Bipedal(name);
                case "q":
                    return new Quadrupedal(name);
                case "a":
                    return new Arachnid(name);
                case "r":
                    return new Radial(name);
                case "ae":
                    return new Aeronautical(name);
                default:
                    return new Unipedal(name);
            }
        }
    }
}

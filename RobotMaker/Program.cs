using System;
using System.Linq;
using System.Threading;

namespace RobotMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var stop = false;
            var userTaskList = new MasterTasksList();

            while (!stop) {
                Console.WriteLine("You need to complete the following tasks:");
                foreach (var task in userTaskList.Tasks)
                {
                    Console.WriteLine(task.Description);
                }
                Console.WriteLine("Let's build a robot to help you out!");

                RobotFactory.DisplaySelections();
                var selection = Console.ReadLine();
                Console.WriteLine("What is your robot's name?");
                var name = Console.ReadLine();
                var robot = RobotFactory.Build(selection, name);

                Console.WriteLine($"You built a {robot.GetType().Name} named {robot.Name}!");
                Console.WriteLine($"{robot.Name} wants to help out! Please wait for {robot.Name} to complete their tasks.");
                foreach (var task in robot.Tasks)
                {
                    if (userTaskList.Tasks.Any(x => x.Description == task.Description))
                    {
                        Console.WriteLine($"Completing task: {task.Description}...");
                        Thread.Sleep(task.Eta);
                        userTaskList.Tasks.RemoveAll(x => x.Description == task.Description);
                        Console.WriteLine("...Done!");
                    }
                }
                Console.WriteLine($"{robot.Name} completed all their tasks!");

                Console.WriteLine("Would you like to build another robot?");
                var stopProgram = Console.ReadLine();
                if(stopProgram.ToLower() == "no" || stopProgram.ToLower() == "n")
                {
                    stop = true;
                }
            }
        }
    }
}

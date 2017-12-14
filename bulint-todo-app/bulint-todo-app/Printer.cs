using System;

namespace bulint_todo_app
{
    public class Printer
    {
        public static void PrintUsage()
        {
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================");
            Console.WriteLine("\nCommand line arguments:");
            Console.WriteLine("-l   Lists all the tasks");
            Console.WriteLine("-a   Adds a new task");
            Console.WriteLine("-r   Removes a task");
            Console.WriteLine("-c   Completes a task");
        }
    }
}



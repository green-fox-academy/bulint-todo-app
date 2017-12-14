using System;

namespace bulint_todo_app
{
    class Printer
    {
        public static void Printer(string[] array)
        {
            foreach (var argument in array)
            {
                if (array.Length == 0)
                {
                    Console.WriteLine("Command Line Todo application");
                    Console.WriteLine("=============================");
                    Console.WriteLine("\nCommand line arguments:");
                    Console.WriteLine("-l   Lists all the tasks");
                    Console.WriteLine("-a   Adds a new task");
                    Console.WriteLine("-r   Removes a task");
                    Console.WriteLine("-c   Completes a task");
                }
                else if (argument == "-l")
                {
                    FileHandler();
                }
            }
        }
    }
}

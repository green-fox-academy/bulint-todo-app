using System;
using System.IO;

namespace bulint_todo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer(args);
        }

        public static void Printer(string[] array)
        {
            foreach (var argument in array)
            {
                if (argument == null)
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

        public static void FileHandler()
        {
            string path = @"C:\Users\L\greenfox\bulint-todo-app\theFile.txt";
            string[] content = File.ReadAllLines(path);
            if (content.Length == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + content[i]);
                }
            }
        }
    }
}

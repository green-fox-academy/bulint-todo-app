using System;
using System.IO;

namespace bulint_todo_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Printer.PrintUsage();
            }
            else if (args[0] == "-l")
            {
                if (args.Length > 1)
                {
                    Console.WriteLine("Unsupported argument");
                }
                else
                {
                    FileHandler.ReadAllTaskFromTheFile();
                }
            }
            else if (args[0] == "-a")
            {
                if (args.Length > 1)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        FileHandler.AddNewTask(args[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            Console.ReadLine();
        }
    }
}


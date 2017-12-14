using System;
using System.IO;

namespace bulint_todo_app
{
    public class FileHandler
    {
        public static void ReadAllTaskFromTheFile()
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

        public static void AddNewTask(string input)
        {
            string path = @"C:\Users\L\greenfox\bulint-todo-app\theFile.txt";
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                outputFile.WriteLine(input);
            }
        }
    }
}


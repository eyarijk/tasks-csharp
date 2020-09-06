using System;
using System.Reflection;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            Tasks tasks = new Tasks();

            while (true)
            {
                Console.WriteLine("Hello write pls number of task from 1 to 32");
                string number = Console.ReadLine();

                MethodInfo methodTask = tasks.GetType().GetMethod("Task" + number);

                if (methodTask == null)
                {
                    Console.WriteLine("Task not found try again.");
                    continue;
                }

                methodTask.Invoke(tasks, null);
            }
        }
    }
}

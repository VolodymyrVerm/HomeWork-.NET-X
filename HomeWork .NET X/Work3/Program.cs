using System;
using Training.common.Interfaces;
using Work3.Tasks.Task1;
using Work3.Tasks.Task2;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Work3-----");
            IRunnable[] tasks = { new Task1(), new Task2() };
            foreach (var i in tasks)
            {
                i.Run();
            }
        }
    }
}

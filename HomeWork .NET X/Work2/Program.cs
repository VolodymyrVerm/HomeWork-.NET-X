namespace HomeWork_.NET_X
{
    using System;
    using Work2.Task3;
    using HomeWork_.NET_X.Training3;
    using Training.common.Interfaces;
    using Work2.Tasks.Task4;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Work2-----");
            IRunnable[] tasks = { new TaskSqaureAbstract(), new TaskRectangleAbstract(), new Task3SqaureVirtual(), new Task3RectangleVirtual(), new Task() };
            foreach(var i in tasks)
            {
                i.Run();
            }
        }
    }
}


namespace Work2
{
    using System;
    using Training.common.Interfaces;
    using Work2.Tasks.Task4;
    using Work2.Tasks;
    using Work2.Tasks.Task3;


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

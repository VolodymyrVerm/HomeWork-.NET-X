namespace Work1
{
    using System;
    using Work1.Tasks;
    using Training.common.Interfaces;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Work1-----");
            IRunnable[] tasks = { new Task1Rectangle(), new Task2Rectangle(), new Task3Circle(), new Task4Rectangle(), new Task4Circle(), new Task5Complexnumber() };
            foreach (var i in tasks)
            {
                i.Run();
            }
        }
    }

}

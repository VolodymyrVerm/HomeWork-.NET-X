namespace Work2.Tasks
{
    using System;
    using Training.common.Interfaces;

    public class TaskRectangleAbstract:Task1FigureAbstract, IRunnable
    {
        public TaskRectangleAbstract() { }

        public TaskRectangleAbstract(int _x,int _y):base(_x,_y)
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Rectangle");
        }

        public void Run()
        {
            TaskRectangleAbstract task = new TaskRectangleAbstract();
            task.Show();            
        }
    }
}

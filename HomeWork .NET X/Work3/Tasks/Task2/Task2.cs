using System;
using System.Collections.Generic;
using System.Text;
using Training.common.Interfaces;

namespace Work3.Tasks.Task2
{
    public class Task2:IRunnable
    {
        public List<Person> FillAndReturnData()
        {
            
            Task1.Task1 tsk = new Task1.Task1();
            List<Person> ListPerson = tsk.FillAndReturnData();
            List<Person> ExtraList = new List<Person>();

            //Створення сьомої персони
            Person person_seven = new Person();
            person_seven.Age = 55;
            person_seven.Name = "Dima";
            person_seven.PhoneNumbers = new List<string> { "525252525", "98978142", "9874654132" };

            //Добавлення в ліст сьомої персони
            ListPerson.Add(person_seven);

            //Створення восьмої персони
            Person person_eight = new Person();
            person_eight.Age = 22;
            person_eight.Name = "Tania";
            person_eight.PhoneNumbers = new List<string> { "0987878958", "0631245789", "05512347896" };

            //Добавлення в ліст восьмої персони
            ListPerson.Add(person_eight);

            ListPerson.AddRange(ExtraList);

            return ListPerson;
        }

        public void Run()
        {
            Console.WriteLine("--Task2--");

            List<Person> list = FillAndReturnData();
            
            foreach (var i in list)
            {

                Console.Write("Name: {0}/ Age: {1}", i.Name, i.Age);
                foreach(var j in i.PhoneNumbers)
                {
                    Console.Write("/ Phone number: {0}",j);

                }
                Console.WriteLine();
            }

        }
    }
}

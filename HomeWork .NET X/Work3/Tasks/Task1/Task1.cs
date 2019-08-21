using System;
using System.Collections.Generic;
using System.Text;
using Training.common.Interfaces;

namespace Work3.Tasks.Task1
{
    public class Task1:IRunnable
    {
        public List<Person> FillData()
        {
            List<Person> ListPerson = new List<Person>();

            //Створення першої персони
            Person person_first = new Person();
            person_first.Age = 30;
            person_first.Name = "Volodymyr";
            person_first.PhoneNumbers = new List<string> { "0981234567", "0000000000", "1234567892" };

            //Добавлення в ліст першої персони
            ListPerson.Add(person_first);

            //Створення другої персони
            Person person_second = new Person();
            person_second.Age = 20;
            person_second.Name = "Oleg";
            person_second.PhoneNumbers = new List<string> { "0981237777", "9874563120", "123004789" };

            //Добавлення в ліст другої персони
            ListPerson.Add(person_second);

            //Створення третьої персони
            Person person_third = new Person();
            person_third.Age = 40;
            person_third.Name = "Ivan";
            person_third.PhoneNumbers = new List<string> { "154236987", "1111111111", "852314679" };

            //Добавлення в ліст третьої персони
            ListPerson.Add(person_third);

            //Створення четвертої персони
            Person person_four = new Person();
            person_four.Age = 20;
            person_four.Name = "Arkadii";
            person_four.PhoneNumbers = new List<string> { "0000000000", "2222222222", "741241277" };

            //Добавлення в ліст четвертої персони
            ListPerson.Add(person_four);

            //Створення п'ятої персони
            Person person_five = new Person();
            person_five.Age = 85;
            person_five.Name = "Oleksii";
            person_five.PhoneNumbers = new List<string> { "666666666", "1313131313", "7777777777" };

            //Добавлення в ліст п'ятої персони
            ListPerson.Add(person_five);

            //Створення шостої персони
            Person person_six = new Person();
            person_six.Age = 25;
            person_six.Name = "Sergii";
            person_six.PhoneNumbers = new List<string> { "1414141414", "5555555555", "1818975236" };

            //Добавлення в ліст шостої персони
            ListPerson.Add(person_six);

            return ListPerson;
        }

        public void Run()
        {
            List<Person> ListPerson = FillData();

            foreach(var i in ListPerson)
            {
                Console.WriteLine("{0}-{1}", i.Name, i.Age);
            }

        }
    }
}

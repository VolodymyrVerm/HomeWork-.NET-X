using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Xml;
using Training.common.Interfaces;

namespace Work3.Tasks.Task3
{
    public class Task3: IRunnable
    {
        private const int NumberOfItems = 5;
        private string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        private List<string> FillDataList()
        {
            List<string> res=new List<string>();
            while (res.Count<100)
            {
                res.Add(RandomString());
            }
            return res;
        }

        private List<string> FirstExercise(List<string> list)
        {
            var hashSet=new HashSet<string>(list);
            var resultList = new List<string>(hashSet);
            resultList.RemoveAll(i => i.StartsWith('Z'));
            resultList.Sort((x,y)=>y.CompareTo(x));
            return resultList;

        }

        private void DisplayPage(int pageNumber, List<string> list)
        {
            int startElement = NumberOfItems * pageNumber - NumberOfItems;
            int finishElement = startElement + NumberOfItems;
            for (int i = startElement; i < finishElement; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void Run()
        {
            Console.WriteLine("--Task3--");

            var listFirst = FillDataList();
            Console.WriteLine("Number of items in the list before the transformation {0}", listFirst.Count);

            var listWithOptions = FirstExercise(listFirst);
            Console.WriteLine("Number of items in the list after the transformation {0}", listWithOptions.Count);

            Console.WriteLine("Please input page(1-20)");
            string input = Console.ReadLine();
            int pageNumber;
            if (!int.TryParse(input,out pageNumber))
            {
                System.Environment.Exit(0);
            }
            if (pageNumber < 1 || pageNumber > 20)
            {
                throw new ArgumentException("Sorry, no such page! ");
            }
            DisplayPage(pageNumber, listWithOptions);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            bool result = false;

            do
            {
                Console.WriteLine("Give a number. ");
                string line = Console.ReadLine();

                int number;
                result = int.TryParse(line, out number);
                if (result)
                {
                    list.Add(number);
                }
            } while (result);


            for(int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                if (i == list.Count - 1)
                    Console.WriteLine(number + "\n");
                else
                    Console.WriteLine(number + ",");
            }


            Console.WriteLine("Average: {0}", list.Average());
            Console.WriteLine("Min: {0}", list.Min());
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Numbers: {0}", list.Count());

            list.Sort();
            list.ForEach(item => Console.Write(item + ","));

        }
    }
}

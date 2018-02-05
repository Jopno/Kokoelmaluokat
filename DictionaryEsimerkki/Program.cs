using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackStrings = new Stack<string>();
            stackStrings.Push("1st");
            stackStrings.Push("2nd");
            stackStrings.Push("3rd");

            Console.WriteLine(stackStrings.Peek());
            Console.WriteLine("");

            foreach (string s in stackStrings)
            {
                Console.WriteLine(s);
            }

            string temp = stackStrings.Pop();
            Console.WriteLine("Just popped: {0}", temp);
            Console.WriteLine("Stack count: {0}", stackStrings.Count);


        }  

    }
}

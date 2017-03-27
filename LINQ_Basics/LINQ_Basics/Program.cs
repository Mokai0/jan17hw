using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> sayGreeting;
            sayGreeting = delegate(string name)
            {
                Console.WriteLine(string.Format("Hello, {0}", name));
            };

            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            sayGreeting(input);
            Console.ReadLine();
            sayGreeting = delegate (string name)
            {
                Console.WriteLine(string.Format("Later, {0}", name));
            };
            sayGreeting(input);
            Console.ReadKey();
        }
    }
}

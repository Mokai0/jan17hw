using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Basics
{
    class Program
    {
        delegate void SayGreeting(string name);

        public static void SayHello(string name)
        {
            Console.WriteLine(string.Format("Hello, {0}", name));
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine(string.Format("Later, {0}", name));
        }

        static void Main(string[] args)
        {
            SayGreeting sayGreeting = new SayGreeting(SayHello);
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            sayGreeting(input);
            Console.ReadLine();
            sayGreeting = new SayGreeting(SayGoodbye);
            sayGreeting(input);
            Console.ReadKey();
        }
    }
}

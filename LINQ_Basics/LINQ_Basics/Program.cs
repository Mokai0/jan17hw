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

            Func<string, string> conversate = (message) =>
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            };
            
            string input = conversate("What's your name?");

            sayGreeting = (greeting) =>
            {
                Console.WriteLine(string.Format(greeting, input));
            };

            sayGreeting("Hello, {0}");
            conversate("Nice to see ya!");
            conversate("How are you doing?");
            sayGreeting("Later, {0}");
            Console.ReadKey();
        }
    }
}

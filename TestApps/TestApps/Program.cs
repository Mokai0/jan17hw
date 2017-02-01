using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApps
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Enter the number of times to print \"Yay!\": ");

            var count = 0;

            while (true)
            {
                try
                {
                    string entry = Console.ReadLine();
                    if (entry.ToLower() == "q")
                    {
                        break;
                    }
                    var limit = int.Parse(entry);
                    while (count < limit)
                    {
                        Console.Write("Yay!");
                        count += 1;
                        continue;
                    }
                    count = 0;
                Console.WriteLine("Okay, what now? (Press q to quit)");
                }
                catch (FormatException)
                {
                    Console.WriteLine("I need a number, ding dong!");
                }
            }
        }
    }
}

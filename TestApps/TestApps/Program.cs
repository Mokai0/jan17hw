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
            while (true)
            {
                try
                {
                    string entry = Console.ReadLine();
                    var limit = int.Parse(entry);
                    var count = 0;
                    if (count < limit)
                    {
                        Console.Write("Yay!");
                        count += 1;
                    }
                    else
                    {
                        Console.WriteLine("Okay, what now?");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("I need a number, ding dong!");
                }
            }
        }
    }
}

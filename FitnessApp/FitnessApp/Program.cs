using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                // Prompt user for time exercised
                Console.Write("How many minutes did you workout for? (Type 'quit' if you whimped out, lol) ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    // Add time to total
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;

                    //Display total time
                    Console.Write("You've worked out for: " + runningTotal + " minutes!");
                }
                Console.WriteLine("See ya!");
            }            
        }
    }
}

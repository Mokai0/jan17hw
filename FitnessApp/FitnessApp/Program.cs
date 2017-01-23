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

            // Prompt user for time exercised
            Console.Write("How many minutes did you workout for? ");
            string entry = Console.ReadLine();

            // Add time to total

            //Display total time
            Console.Write("You've worked out for: " + entry + " minutes!");
        }
    }
}

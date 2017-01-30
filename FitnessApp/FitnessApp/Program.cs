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
            var runningTotal = 0.0;

            while (true)
            {
                // Prompt user for time exercised
                Console.Write("How many minutes did you workout for? (Type 'quit' if you whimped out, lol) ");
                try
                {
                    string entry = Console.ReadLine();
                    if (entry.ToLower() == "quit")
                    {
                        Console.WriteLine("See ya!");
                        Console.ReadKey();
                        break;
                    }

                    // Add time to total
                    double minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine("You're a failure...");
                        Console.WriteLine("but then again you might have just typed something wrong.");
                        Console.WriteLine("Here try again:");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("You can do better!");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Okay, now we're getting somewhere! *clap clap*");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Feel the BURN! Keep going champ!");
                    }
                    else
                    {
                        Console.WriteLine("THIS IS SPARTA!!!");
                    }

                    runningTotal += minutes;

                    //Display total time
                    Console.WriteLine("You've worked out for: " + runningTotal + " minutes!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That wasn't the information I asked for.");
                }
            }            
        }
    }
}

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
            double runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                // Prompt user for time exercised
                Console.Write("How many minutes did you workout for? (Type 'quit' if you whimped out, lol) ");
                try
                {
                    string entry = Console.ReadLine();
                    if (entry.ToLower() == "quit")
                    {
                        keepGoing = false;
                    }
                    else
                    {
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

                        runningTotal = runningTotal + minutes;

                        //Display total time
                        Console.Write("You've worked out for: " + runningTotal + " minutes!");
                    }
                    Console.WriteLine("See ya!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That wasn't the information I asked for.");
                }
            }            
        }
    }
}

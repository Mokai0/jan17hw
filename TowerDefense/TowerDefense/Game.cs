using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[]
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                //MapLocation location = path.GetLocationAt(0);
                //if(location != null)
                //{
                //    Console.WriteLine(location.X + "," + location.Y);
                //}

                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);

                invader.Location = location;
                //setting
                location = invader.Location;
                //getting
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TowerDefenseException)
            {
                Console.WriteLine("Unhandeled TowerDefenceException");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception : " + ex);
            }

            Console.ReadKey();
        }
    }
}

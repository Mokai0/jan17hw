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

            Point point = new Point(4, 2);

            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
            point = new Point(8, 5);
            isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
            Console.ReadKey();
        }
    }
}

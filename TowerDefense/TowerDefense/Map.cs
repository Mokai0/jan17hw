using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;

            //bool outOfBounds = point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height;

            //inBounds = !outOfBounds;
            
            //The above is an example of how you would utilize a "or" operator to define the same desired code, however it is redundant in this situation.

            return inBounds;
        }
    }
}
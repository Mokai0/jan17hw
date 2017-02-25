using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;        
        }

        public void ShootEm(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {

            }
        }
    }
}

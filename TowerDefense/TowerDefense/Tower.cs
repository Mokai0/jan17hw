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
            for(int i = 0; i <invaders.Length; i++)
            {
                Invader invader = invaders[i];
                //Do stuff with invader
            }
        }
    }
}

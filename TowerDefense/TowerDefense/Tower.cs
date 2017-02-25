using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;        
        }

        public void ShootEm(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsAlive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }
    }
}

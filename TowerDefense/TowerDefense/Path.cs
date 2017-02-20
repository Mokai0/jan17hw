using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public GetLocationAt(int pathStep)
        {
            if(pathStep < _path.length)
            {
                return _path[pathStep];
            }
            else
            {
                return null;
            }
        }
    }
}

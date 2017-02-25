using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);
        //The above is the syntactic sugar for the below code block, so long as it takes a single statement and is used strictly for computed properties this will work!
        //{ get { return _path.GetLocationAt(_pathStep); } }        

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;
        //Similarly this would be how you write syntactic sugar for single statement methods. Notice how the parentheses, "()", are still there - that's a clear indication of this line being a method. Another difference is that properties will ALWAYS return a value whereas this method, because of 'void', will not.
        //{ _pathStep += 1; }
    }
}

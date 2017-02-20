using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        public MapLocation Location { get; private set; }
        //Keeping the setter private is a common practice - it future proofs the code so that you can change the field's contents when working within the same class and ensure it's entgrity out side of the class. At the same time its a good idea to keep the getter public to allow access to the information from outside the class.
    }
}

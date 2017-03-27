using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Basics.BirdsExample
{
    public static class BirdRepository
    {
        public static List<Bird> birds = new List<Bird>
        {
            new Bird {Name="Cardinal", Color="Red", Sightings=3 },
            new Bird {Name="Dove", Color="White", Sightings=2 },
            new Bird {Name="Robin", Color="Red", Sightings=5 },
            new Bird {Name="Blue Jay", Color="Blue", Sightings=1 }
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private MapLocation _location;
        //Since the invader's location will keep changing we can't use a 'readonly' statement, and making it 'public' wouldn't be a good idea as it exposes too much of the program itself. Therefore it must be private. That being said external classes need to be able to access and modify the information of this field and therfore we'll be using a common practice known as accessor methods. They are a combination of code snippets that allow you to 'get' the information you want from the field and 'set' the new information that you've processed into that field - aptly named getter and setter methods.

        //public MapLocation GetLocation()
        //{
        //    return _location;
        //}
        //public void SetLocation(MapLocation value)
        //{
        //    _location = value;
        //}
        //Above is the broken down and splayed code of what is below. Getter's and Setter's are so common in C# that what you see below is a common conventional shorthand for both seperate snippets of code. These shorthands are called 'properties'.

        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                Console.WriteLine("The invader moved!");
            }
        }
    }
}

﻿using System.Collections.Generic;
using System.Linq;
using static DataStructPractice.EnumerableCompositor;

namespace DataStructPractice
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set1 = new HashSet<int> { 3, 6, 9, 12, 15 };
            var array1 = new[] { 4, 8, 12, 16, 20 };

            //var ec = new EnumerableCompositor<int>(new IEnumerable<int>[] { list1, list2, set1, array1 });
            //This setup will allow you to add references to the collections and their items w/o explicity copyint the items. That way should any of the expected collections change that change would be directly translated automatically.

            int numOdd = EC(list1, list2, set1, array1).Count(x => IsOdd(x));

            HashSet<int> set = EC(list1, list2, set1, array1).To<HashSet<int>>();
        }
    }
}

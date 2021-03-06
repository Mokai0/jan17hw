﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollections
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student() {Name = "Mark", GradeLevel = 3},
                new Student() {Name = "Jack", GradeLevel = 3},
                new Student() {Name = "Mark", GradeLevel = 2},
            };

            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);


            foreach (Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
            Console.ReadKey();
        }
    }
}
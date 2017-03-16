using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollections
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>;

        public IEnumerable<Student> Students { get { return _students; } }

        public void AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(students);
        }
    }
}

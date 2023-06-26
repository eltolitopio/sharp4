using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4lab_
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<string, int> Grades { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Grades = new Dictionary<string, int>();
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}

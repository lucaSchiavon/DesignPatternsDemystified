using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.StudentIterator
{
    //class representing individual student records
    public class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }

        public Student(string name, int studentID)
        {
            Name = name;
            StudentID = studentID;
        }
    }
}

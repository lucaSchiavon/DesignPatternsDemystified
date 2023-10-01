using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.StudentIterator
{
    //Create the Concrete Aggregate
    public class StudentList : IAggregate
    {
        private ArrayList _students = new ArrayList();

        public void AddStudent(object student)
        {
            _students.Add(student);
        }

        public IIterator CreateIterator()
        {
            return new StudentIterator(_students);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.StudentIterator
{
    //the Concrete Iterator
    public class StudentIterator : IIterator
    {
        private ArrayList _students;
        private int _position = 0;

        public StudentIterator(ArrayList students)
        {
            _students = students;
        }

        public bool HasNext()
        {
            return _position < _students.Count;
        }

        public object Next()
        {
            if (HasNext())
            {
                object nextStudent = _students[_position];
                _position++;
                return nextStudent;
            }
            else
            {
                return null;
            }
        }
    }
}

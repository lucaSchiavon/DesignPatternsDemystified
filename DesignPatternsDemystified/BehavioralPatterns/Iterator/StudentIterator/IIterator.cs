using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.StudentIterator
{
    //the Iterator interface
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}

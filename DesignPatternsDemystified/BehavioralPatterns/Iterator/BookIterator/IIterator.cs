using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.BookIterator
{
    //the Iterator interface
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}

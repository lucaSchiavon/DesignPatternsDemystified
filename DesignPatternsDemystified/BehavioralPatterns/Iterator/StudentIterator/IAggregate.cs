using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.StudentIterator
{
    //the Aggregate interface
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}

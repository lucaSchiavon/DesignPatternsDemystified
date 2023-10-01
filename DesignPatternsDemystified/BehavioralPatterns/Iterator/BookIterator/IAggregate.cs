﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Iterator.BookIterator
{
    //the Aggregate interface
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}

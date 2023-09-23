using System;
using System.Collections.Generic;

namespace DesignPatternsDemystified.BehavioralPatterns
{
    // Define the abstract Element class that will be visited by the Visitor.
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}

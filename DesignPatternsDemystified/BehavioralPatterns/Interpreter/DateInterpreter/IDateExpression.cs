using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.DateInterpreter
{
    // Abstract Expression
    public interface IDateExpression
    {
        DateTime Interpret(DateTime context);
    }
}

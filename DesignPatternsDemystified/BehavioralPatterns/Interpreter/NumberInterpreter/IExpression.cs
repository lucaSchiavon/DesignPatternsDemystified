using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.NumberInterpreter
{
    // Abstract Expression
    public interface IExpression
    {
        int Interpret(Dictionary<string, int> context);
    }
}

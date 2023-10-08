using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.NumberInterpreter
{
    // Terminal Expression for variables
    public class VariableExpression : IExpression
    {
        private readonly string _variableName;

        public VariableExpression(string variableName)
        {
            _variableName = variableName;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            if (context.ContainsKey(_variableName))
            {
                return context[_variableName];
            }
            else
            {
                throw new InvalidOperationException($"Variable {_variableName} not found in the context.");
            }
        }
    }

}

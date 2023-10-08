using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.DateInterpreter
{
    // Non-Terminal Expression for adding days
    public class AddDaysExpression : IDateExpression
    {
        private readonly IDateExpression _expression;
        private readonly int _daysToAdd;

        public AddDaysExpression(IDateExpression expression, int daysToAdd)
        {
            _expression = expression;
            _daysToAdd = daysToAdd;
        }

        public DateTime Interpret(DateTime context)
        {
            var baseDate = _expression.Interpret(context);
            return baseDate.AddDays(_daysToAdd);
        }
    }
}

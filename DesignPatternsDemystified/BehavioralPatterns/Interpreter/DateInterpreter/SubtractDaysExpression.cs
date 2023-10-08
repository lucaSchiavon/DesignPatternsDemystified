using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.DateInterpreter
{
    // Non-Terminal Expression for subtracting days
    public class SubtractDaysExpression : IDateExpression
    {
        private readonly IDateExpression _expression;
        private readonly int _daysToSubtract;

        public SubtractDaysExpression(IDateExpression expression, int daysToSubtract)
        {
            _expression = expression;
            _daysToSubtract = daysToSubtract;
        }

        public DateTime Interpret(DateTime context)
        {
            var baseDate = _expression.Interpret(context);
            return baseDate.AddDays(-_daysToSubtract);
        }
    }
}

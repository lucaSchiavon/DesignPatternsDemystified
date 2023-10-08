using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.DateInterpreter
{
    // Terminal Expression for a specific date
    public class DateExpression : IDateExpression
    {
        private readonly DateTime _date;

        public DateExpression(DateTime date)
        {
            _date = date;
        }

        public DateTime Interpret(DateTime context)
        {
            return _date;
        }
    }
}

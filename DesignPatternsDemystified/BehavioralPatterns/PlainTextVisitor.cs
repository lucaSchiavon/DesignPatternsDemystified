using System;
using System.Collections.Generic;

namespace DesignPatternsDemystified.BehavioralPatterns
{
    // Concrete implementation of plain text generation visitor.
    class PlainTextVisitor : IVisitor
    {
        public void VisitTextElement(TextElement textElement)
        {
            Console.WriteLine(textElement.Text);
        }

        public void VisitHyperlinkElement(HyperlinkElement hyperlinkElement)
        {
            Console.WriteLine($"{hyperlinkElement.Text} ({hyperlinkElement.Url})");
        }
    }
}

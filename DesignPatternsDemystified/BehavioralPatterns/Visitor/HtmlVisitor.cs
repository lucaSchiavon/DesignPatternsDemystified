using System;
using System.Collections.Generic;

namespace DesignPatternsDemystified.BehavioralPatterns.Visitor
{
    // Concrete implementation of HTML generation visitor.
    class HtmlVisitor : IVisitor
    {
        public void VisitTextElement(TextElement textElement)
        {
            Console.WriteLine($"<p>{textElement.Text}</p>");
        }

        public void VisitHyperlinkElement(HyperlinkElement hyperlinkElement)
        {
            Console.WriteLine($"<a href=\"{hyperlinkElement.Url}\">{hyperlinkElement.Text}</a>");
        }
    }
}

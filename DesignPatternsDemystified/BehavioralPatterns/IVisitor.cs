using System;
using System.Collections.Generic;

namespace DesignPatternsDemystified.BehavioralPatterns
{
    // Define the Visitor interface.
    interface IVisitor
    {
        void VisitTextElement(TextElement textElement);
        void VisitHyperlinkElement(HyperlinkElement hyperlinkElement);
    }
}

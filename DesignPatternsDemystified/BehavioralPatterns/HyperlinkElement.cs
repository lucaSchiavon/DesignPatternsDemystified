using System;
using System.Collections.Generic;

namespace DesignPatternsDemystified.BehavioralPatterns
{
    // Concrete HyperlinkElement class representing hyperlinks.
    class HyperlinkElement : Element
    {
        public string Url { get; set; }
        public string Text { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitHyperlinkElement(this);
        }
    }
}

using System;
using System.Collections.Generic;

namespace DesignPatternsDemystified.BehavioralPatterns
{
    // Concrete TextElement class representing text content.
    class TextElement : Element
    {
        public string Text { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitTextElement(this);
        }
    }
}

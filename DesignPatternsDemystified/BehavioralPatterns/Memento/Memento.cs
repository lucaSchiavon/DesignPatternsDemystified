using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Memento
{
    // Memento class
    public class TextEditorMemento
    {
        public string SavedText { get; private set; }

        public TextEditorMemento(string text)
        {
            SavedText = text;
        }
    }
}

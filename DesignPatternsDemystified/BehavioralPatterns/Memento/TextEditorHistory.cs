using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Memento
{
    // Caretaker class
    class TextEditorHistory
    {
        public TextEditorMemento Memento { get; set; }
    }
}

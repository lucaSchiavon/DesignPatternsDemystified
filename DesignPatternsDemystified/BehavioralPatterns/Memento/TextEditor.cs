using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Memento
{
    //Originator class
    public class TextEditor
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(text);
        }

        public void Restore(TextEditorMemento memento)
        {
            text = memento.SavedText;
        }

        public override string ToString()
        {
            return text;
        }
    }
}

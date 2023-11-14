using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Composite
{
    public class Window : UIComponent
    {
        private List<UIComponent> components = new List<UIComponent>();

        public void AddComponent(UIComponent component)
        {
            components.Add(component);
        }

        public override void Display()
        {
            Console.WriteLine("Window:");
            foreach (var component in components)
            {
                component.Display();
            }
        }
    }
}

using DesignPatternsDemystified.BehavioralPatterns.TemplateMethod;
using DesignPatternsDemystified.BehavioralPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesignPatternsDemystified
{
    /// <summary>
    /// Logica di interazione per BehavioralPattern.xaml
    /// </summary>
    public partial class BehavioralPattern : Window
    {
        public BehavioralPattern()
        {
            InitializeComponent();
        }

        private void BtnVisitor_Click(object sender, RoutedEventArgs e)
        {
            // Create a list of elements in a document.
            List<Element> elements = new List<Element>
        {
            new BehavioralPatterns.Visitor.TextElement { Text = "This is a paragraph of text." },
            new HyperlinkElement { Url = "https://www.example.com", Text = "Visit Example.com" }
        };

            // Create visitors (HTML and plain text) and apply them to the elements.
            IVisitor htmlVisitor = new HtmlVisitor();
            IVisitor plainTextVisitor = new PlainTextVisitor();

            Console.WriteLine("HTML Output:");
            foreach (var element in elements)
            {
                element.Accept(htmlVisitor);
            }

            Console.WriteLine("\nPlain Text Output:");
            foreach (var element in elements)
            {
                element.Accept(plainTextVisitor);
            }
        }

        private void BtnTemplateMethod_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Making a BLT Sandwich:");
            Sandwich bltSandwich = new BLTSandwich();
            bltSandwich.MakeSandwich();

            Console.WriteLine("\nMaking a Veggie Sandwich:");
            Sandwich veggieSandwich = new VeggieSandwich();
            veggieSandwich.MakeSandwich();
        }
    }
}

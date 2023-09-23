using System;
using System.Collections.Generic;

// Define the abstract Element class that will be visited by the Visitor.
abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}

// Concrete TextElement class representing text content.
class TextElement : Element
{
    public string Text { get; set; }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitTextElement(this);
    }
}

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

// Define the Visitor interface.
interface IVisitor
{
    void VisitTextElement(TextElement textElement);
    void VisitHyperlinkElement(HyperlinkElement hyperlinkElement);
}

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

class Program
{
    static void Main(string[] args)
    {
        // Create a list of elements in a document.
        List<Element> elements = new List<Element>
        {
            new TextElement { Text = "This is a paragraph of text." },
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
}

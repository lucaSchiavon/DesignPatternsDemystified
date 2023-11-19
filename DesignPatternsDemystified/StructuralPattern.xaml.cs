using DesignPatternsDemystified.CreationalPatterns.Singleton;
using DesignPatternsDemystified.CreationalPatterns.FactoryMethod;
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
using Point = DesignPatternsDemystified.CreationalPatterns.FactoryMethod.Point;
using DesignPatternsDemystified.CreationalPatterns.AbstractFactory;
using DesignPatternsDemystified.CreationalPatterns.Builder;
using DesignPatternsDemystified.CreationalPatterns.Prototype;
using DesignPatternsDemystified.StructuralPatterns.Bridge;
using DesignPatternsDemystified.StructuralPatterns.Composite;
using DesignPatternsDemystified.StructuralPatterns.Decorator;
using DesignPatternsDemystified.StructuralPatterns.Facade;
using DesignPatternsDemystified.StructuralPatterns.Flyweight;

namespace DesignPatternsDemystified
{

    public partial class StructuralPattern : System.Windows.Window
    {
        public StructuralPattern()
        {
            InitializeComponent();
        }

        #region Structural patterns

        private void BtnAdapter_Click(object sender, RoutedEventArgs e)
        {
            StructuralPatterns.Adapter.ImageView imageView = new StructuralPatterns.Adapter.ImageView(new StructuralPatterns.Adapter.Image());
            imageView.Apply(new StructuralPatterns.Adapter.SoftFilter());
            //apply adapter to adapt a third parts component call 
            imageView.Apply(new StructuralPatterns.Adapter.MosaicAdapter(new StructuralPatterns.Adapter.ThirdParts.Mosaic()));
        }





        #endregion

        private void BtnBridge_Click(object sender, RoutedEventArgs e)
        {
            RemoteControl RemoteControl = new(new SonyTv());
            RemoteControl.TurnOn();

            AdvanceRemoteControl advanceRemoteControl = new AdvanceRemoteControl(new SonyTv());
            advanceRemoteControl.SetChannel(5);


        }

        private void BtnComposite_Click(object sender, RoutedEventArgs e)
        {
            var button1 = new StructuralPatterns.Composite.Button("OK");
            var button2 = new StructuralPatterns.Composite.Button("Cancel");
            var textBox = new StructuralPatterns.Composite.TextBox("Type something here");

            // Creating composite element
            var window = new StructuralPatterns.Composite.Window();
            window.AddComponent(button1);
            window.AddComponent(button2);
            window.AddComponent(textBox);

            // Displaying the composite (window) which in turn displays its children
            window.Display();
        }

        private void BtnDecorator_Click(object sender, RoutedEventArgs e)
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine("Cost of simple coffee: " + coffee.Cost());

            coffee = new MilkDecorator(coffee);
            Console.WriteLine("Cost of milk coffee: " + coffee.Cost());

            coffee = new SugarDecorator(coffee);
            Console.WriteLine("Cost of sugar and milk coffee: " + coffee.Cost());
        }

        private void BtnFacade_Click(object sender, RoutedEventArgs e)
        {
            // Using the Facade to simplify interaction with the subsystem
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();
            homeTheater.WatchMovie("Inception");

            // After watching the movie, you can use the facade to clean up
            homeTheater.EndMovie();
        }

        private void BtnFlyweight_Click(object sender, RoutedEventArgs e)
        {
            TextEditor textEditor = new TextEditor();

            // Insert characters into the text editor
            textEditor.InsertCharacter('H', 0);
            textEditor.InsertCharacter('e', 1);
            textEditor.InsertCharacter('l', 2);
            textEditor.InsertCharacter('l', 3);
            textEditor.InsertCharacter('o', 4);

            // Display the text
            textEditor.DisplayText();
        }
    }
}

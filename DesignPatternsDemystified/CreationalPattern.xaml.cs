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

namespace DesignPatternsDemystified
{

    public partial class CreationalPattern : Window
    {
        public CreationalPattern()
        {
            InitializeComponent();
        }

        #region Creational patterns

        private void BtnSingleton_Click(object sender, RoutedEventArgs e)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            // The two variables singleton1 and singleton2 share the same Singleton instance.
            Console.WriteLine(singleton1 == singleton2); // Should be "True".
        }

        private void BtnDatabaseConnection_Click(object sender, RoutedEventArgs e)
        {
            // Get the singleton instance of the database connection manager.
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Open and close the database connection.
            dbConnection.OpenConnection();
            dbConnection.CloseConnection();

            // Verify that the singleton instances are the same.
            DatabaseConnection dbConnection2 = DatabaseConnection.Instance;
            Console.WriteLine(dbConnection == dbConnection2); // Should print "True".
        }

        private void BtnAppSettings_Click(object sender, RoutedEventArgs e)
        {
            // Get the Singleton instance of the application settings.
            AppSettings appSettings = AppSettings.Instance;

            // Read and change settings.
            Console.WriteLine("Background Color: " + appSettings.GetSetting("BackgroundColor"));
            Console.WriteLine("Font Color: " + appSettings.GetSetting("FontColor"));

            // Changing the setting.
            appSettings.SetSetting("BackgroundColor", "Blue");
            Console.WriteLine("Updated Background Color: " + appSettings.GetSetting("BackgroundColor"));

            // Check that changes are reflected everywhere.
            AppSettings appSettings2 = AppSettings.Instance;
            Console.WriteLine("Background Color in Another Instance: " + appSettings2.GetSetting("BackgroundColor"));

            // The Singleton instance is the same for appSettings and appSettings2.
            Console.WriteLine(appSettings == appSettings2); // Should print "True".
        }

        #endregion


        private void BtnAbstractFactory_Click(object sender, RoutedEventArgs e)
        {
            // Create a Windows UI Factory
            IUIFactory windowsFactory = new WindowsUIFactory();

            // Create Windows UI components
            IButton windowsButton = windowsFactory.CreateButton();
            ICheckbox windowsCheckbox = windowsFactory.CreateCheckbox();

            windowsButton.Render();
            windowsCheckbox.Render();

            // Create a macOS UI Factory
            IUIFactory macFactory = new MacOSUIFactory();

            // Create macOS UI components
            IButton macButton = macFactory.CreateButton();
            ICheckbox macCheckbox = macFactory.CreateCheckbox();

            macButton.Render();
            macCheckbox.Render();
        }

        private void BtnPointMethod_Click(object sender, RoutedEventArgs e)
        {
            // Client code using Factory Method Pattern.
            CreationalPatterns.FactoryMethod.Point cartesianPoint = Point.NewCartesianPoint(3, 5);
            CreationalPatterns.FactoryMethod.Point polarPoint = Point.NewPolarPoint(3, 5);
        }

        private void BtnBuilder_Click(object sender, RoutedEventArgs e)
        {
            // Create a director and a concrete builder
            var director = new ComputerDirector(new GamingComputerBuilder());

            // Construct a gaming computer
            Computer gamingComputer = director.ConstructComputer();

            // Display computer details
            Console.WriteLine("Gaming Computer Details:");
            gamingComputer.ShowDetails();
        }



        private void BtnPrototype_Click(object sender, RoutedEventArgs e)
        {

            CreationalPatterns.Prototype.Person.Person person1 =
                new("Mario Rossi", new CreationalPatterns.Prototype.Person.Address("Via Mazzini", 15));

            CreationalPatterns.Prototype.Person.Person person2 = person1.DeepCopy();

            person2.Address.HouseNumber = 45;

            //using binary serialization to make a deep copy of all object
            CreationalPatterns.Prototype.Person.Person person3 = person1.DeepBinaryCopy();

            //using binary serialization to make a deep copy of all object
            CreationalPatterns.Prototype.Person.Person person4 = person1.DeepXmlCopy();

        }
    }
}

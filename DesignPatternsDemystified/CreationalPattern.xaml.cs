﻿using DesignPatternsDemystified.CreationalPatterns;
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
    }
}
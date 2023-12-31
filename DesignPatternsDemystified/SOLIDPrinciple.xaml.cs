﻿using DesignPatternsDemystified.SOLIDPrinciples.OCP;
using DesignPatternsDemystified.SOLIDPrinciples.SRP;
using DesignPatternsDemystified.SOLIDPrinciples.ISP;
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
using DesignPatternsDemystified.SOLIDPrinciples.DIP;
using DesignPatternsDemystified.SOLIDPrinciples.LSP;

namespace DesignPatternsDemystified
{
    /// <summary>
    /// Logica di interazione per SOLIDPrinciples.xaml
    /// </summary>
    public partial class SOLIDPrinciple : Window
    {
        public SOLIDPrinciple()
        {
            InitializeComponent();
        }

        private void BtnSRP(object sender, RoutedEventArgs e)
        {
            Feed feed = new Feed();

            feed.AddPost($"This is the first post {Environment.NewLine}");
            feed.AddPost($"This is the second post {Environment.NewLine}");

            SavingManager savingManager = new SavingManager();
            savingManager.Save(feed, @"C:\feed.txt");

        }

        private void BtnOCP(object sender, RoutedEventArgs e)
        {
            SOLIDPrinciples.OCP.Invoice finalInvoice = new FinalInvoice();
            SOLIDPrinciples.OCP.Invoice proposedInvoice = new ProposedInvoice();

            double finalInvoiceAmount = finalInvoice.GetInvoiceDiscount(20000);
            double proposedInvoiceAmount = proposedInvoice.GetInvoiceDiscount(20000);

        }

        private void BtnLSP(object sender, RoutedEventArgs e)
        {
            Animal myPet1 = new Dog();
            Animal myPet2 = new Cat();
            Animal myPet3 = new Fish();

            myPet1.MakeSound(); // Output: A dog barks.
            myPet2.MakeSound(); // Output: A cat meows.
            myPet3.MakeSound(); // Output: A fish doesn't make sound.
        }

        private void BtnISP(object sender, RoutedEventArgs e)
        {
            Document document = new Document();

            Printer printer = new Printer();
            printer.Print(document);

            MultifunctionalPrinter MultifunctionalPrinter = new MultifunctionalPrinter();
            MultifunctionalPrinter.Scan(document);
            MultifunctionalPrinter.Print(document);
            MultifunctionalPrinter.Fax(document);

        }

        private void BtnDIP(object sender, RoutedEventArgs e)
        {
            ExceptionLogger el = new ExceptionLogger(new DbLogger());
            //or
            //ExceptionLogger el = new ExceptionLogger(new FileLogger());
            try
            {
                //here some code...
            }
            catch (Exception ex)
            {
                el.LogException(ex);
                
            }

        }


    }
}

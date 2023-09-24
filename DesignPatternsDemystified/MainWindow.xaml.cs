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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignPatternsDemystified
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreationalPatterns_Click(object sender, RoutedEventArgs e)
        {
            CreationalPattern creationalPatterns = new CreationalPattern();
            creationalPatterns.Show();
        }

        private void BtnBehavioralPatterns_Click(object sender, RoutedEventArgs e)
        {
            BehavioralPattern behavioralPattern = new BehavioralPattern();
            behavioralPattern.Show();
        }

        private void BtnSolidPrinciples_Click(object sender, RoutedEventArgs e)
        {
            SOLIDPrinciple sOLIDPrinciple = new SOLIDPrinciple();
            sOLIDPrinciple.Show();
        }
    }
}

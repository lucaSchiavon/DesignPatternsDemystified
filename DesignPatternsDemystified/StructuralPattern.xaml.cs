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

    public partial class StructuralPattern : Window
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



    }
}

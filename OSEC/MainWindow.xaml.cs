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
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using OSEC.Functionality;
using OSEC.Models;

namespace OSEC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var test = new Calculations();
            test.inputDots = new List<Dots>() {new Dots() {Current = 1, Voltage = 1}, new Dots() {Current = 2, Voltage = 2}, new Dots() {Current = -2, Voltage = -2} };


            var xDataSource = test.inputDots.Select(a => a.Current).ToList().AsXDataSource();
            var yDataSource = test.inputDots.Select(a => a.Voltage).ToList().AsYDataSource();

            xDataSource.SetXMapping(X => X);
            yDataSource.SetYMapping(Y => Y);
            //TODO: виводити потужність для точки, а не дані, очевидні з графіку
            xDataSource.AddMapping(ShapeElementPointMarker.ToolTipTextProperty, X => string.Format("Напруга - {0}", X) );
            
            var compositeDataSource = new CompositeDataSource(xDataSource, yDataSource);
            
            //TODO: виділяти осі координат жирним чи кольором
            VoltAmperChart.AddLineGraph(compositeDataSource, new Pen(Brushes.Gold, 3), new SampleMarker(), new PenDescription());
            VoltAmperChart.FitToView();
            VoltAmperChart.InvalidateVisual();
        }
    }
}

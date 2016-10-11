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
using Microsoft.Research.DynamicDataDisplay.Charts;
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

            var test = new Calculations
            {
                inputDots = new List<Dots>()
                {
                    new Dots(-1.000065E+00, -8.850206E-06),
                    new Dots(-9.798931E-01, -8.959544E-06),
                    new Dots(-9.597698E-01, -9.053667E-06),
                    new Dots(-9.393997E-01, -8.892504E-06),
                    new Dots(-9.193230E-01, -8.510906E-06),
                    new Dots(-8.991212E-01, -8.590137E-06),
                    new Dots(-8.791716E-01, -8.837707E-06),
                    new Dots(-8.586777E-01, -8.979683E-06),
                    new Dots(-8.383751E-01, -8.681114E-06),
                    new Dots(-8.183380E-01, -8.587639E-06),
                    new Dots(-7.981631E-01, -8.958787E-06),
                    new Dots(-7.778298E-01, -9.036549E-06),
                    new Dots(-7.577075E-01, -8.623026E-06),
                    new Dots(-7.375774E-01, -8.330034E-06),
                    new Dots(-7.172545E-01, -8.686243E-06),
                    new Dots(-6.972725E-01, -8.957118E-06),
                    new Dots(-6.767644E-01, -8.606926E-06),
                    new Dots(-6.567520E-01, -8.389269E-06),
                    new Dots(-6.364992E-01, -8.678266E-06),
                    new Dots(-6.163287E-01, -8.697972E-06),
                    new Dots(-5.960365E-01, -8.330575E-06),
                    new Dots(-5.759806E-01, -8.041144E-06),
                    new Dots(-5.557410E-01, -8.377776E-06),
                    new Dots(-5.353180E-01, -8.642602E-06),
                    new Dots(-5.151780E-01, -8.273268E-06),
                    new Dots(-4.951338E-01, -7.917752E-06),
                    new Dots(-4.748872E-01, -8.164194E-06),
                    new Dots(-4.546315E-01, -8.365814E-06),
                    new Dots(-4.344074E-01, -8.061385E-06),
                    new Dots(-4.143732E-01, -7.827268E-06),
                    new Dots(-3.940431E-01, -8.205560E-06),
                    new Dots(-3.738102E-01, -8.335779E-06),
                    new Dots(-3.535796E-01, -8.152224E-06),
                    new Dots(-3.334441E-01, -7.809382E-06),
                    new Dots(-3.133774E-01, -8.061022E-06),
                    new Dots(-2.930106E-01, -8.295562E-06),
                    new Dots(-2.728004E-01, -8.250354E-06),
                    new Dots(-2.525860E-01, -7.955238E-06),
                    new Dots(-2.323492E-01, -7.895934E-06),
                    new Dots(-2.122277E-01, -8.175946E-06),
                    new Dots(-1.920020E-01, -8.061649E-06),
                    new Dots(-1.717696E-01, -7.676455E-06),
                    new Dots(-1.515675E-01, -7.568809E-06),
                    new Dots(-1.314348E-01, -7.939256E-06),
                    new Dots(-1.112870E-01, -8.097301E-06),
                    new Dots(-9.103651E-02, -7.593069E-06),
                    new Dots(-7.087994E-02, -7.461190E-06),
                    new Dots(-5.057450E-02, -7.827478E-06),
                    new Dots(-3.026917E-02, -7.881277E-06),
                    new Dots(-1.020636E-02, -7.428913E-06),
                    new Dots(+9.988291E-03, -7.221872E-06),
                    new Dots(+3.025164E-02, -7.631925E-06),
                    new Dots(+5.049692E-02, -7.740168E-06),
                    new Dots(+7.060324E-02, -7.262707E-06),
                    new Dots(+9.086905E-02, -7.062551E-06),
                    new Dots(+1.110988E-01, -7.205135E-06),
                    new Dots(+1.314000E-01, -7.239218E-06),
                    new Dots(+1.514972E-01, -6.731609E-06),
                    new Dots(+1.719014E-01, -6.671329E-06),
                    new Dots(+1.918811E-01, -7.042216E-06),
                    new Dots(+2.120373E-01, -7.179145E-06),
                    new Dots(+2.322828E-01, -6.905111E-06),
                    new Dots(+2.526543E-01, -6.613750E-06),
                    new Dots(+2.725564E-01, -6.703262E-06),
                    new Dots(+2.928049E-01, -6.887487E-06),
                    new Dots(+3.130648E-01, -6.640816E-06),
                    new Dots(+3.333893E-01, -6.313189E-06),
                    new Dots(+3.537101E-01, -6.482924E-06),
                    new Dots(+3.737153E-01, -6.784560E-06),
                    new Dots(+3.939275E-01, -6.549035E-06),
                    new Dots(+4.142317E-01, -6.013837E-06),
                    new Dots(+4.343283E-01, -5.932371E-06),
                    new Dots(+4.545740E-01, -6.096826E-06),
                    new Dots(+4.746734E-01, -5.825650E-06),
                    new Dots(+4.948490E-01, -5.291064E-06),
                    new Dots(+5.150938E-01, -4.955728E-06),
                    new Dots(+5.351822E-01, -5.059966E-06),
                    new Dots(+5.554933E-01, -4.746620E-06),
                    new Dots(+5.755470E-01, -3.773572E-06),
                    new Dots(+5.959212E-01, -3.141147E-06),
                    new Dots(+6.160362E-01, -2.829730E-06),
                    new Dots(+6.363314E-01, -2.120329E-06),
                    new Dots(+6.565456E-01, -1.108296E-06),
                    new Dots(+6.765975E-01, -2.125089E-07),
                    new Dots(+6.977800E-01, +1.049960E-06),
                    new Dots(+7.170920E-01, +2.179824E-06),
                    new Dots(+7.372948E-01, +3.549885E-06),
                    new Dots(+7.574959E-01, +5.240142E-06),
                    new Dots(+7.776662E-01, +6.599455E-06),
                    new Dots(+7.979321E-01, +7.700452E-06),
                    new Dots(+8.181822E-01, +9.108816E-06),
                    new Dots(+8.382475E-01, +1.068833E-05),
                    new Dots(+8.585311E-01, +1.257301E-05),
                    new Dots(+8.787186E-01, +1.387042E-05),
                    new Dots(+8.989635E-01, +1.513570E-05),
                    new Dots(+9.191633E-01, +1.705537E-05),
                    new Dots(+9.391450E-01, +1.851821E-05),
                    new Dots(+9.595866E-01, +1.962405E-05),
                    new Dots(+9.796951E-01, +2.131314E-05),
                    new Dots(+9.998776E-01, +2.303204E-05)
                }
            };


            var altSource = new EnumerableDataSource<Dots>(test.inputDots);
            altSource.SetXMapping(x => x.Voltage);
            altSource.SetYMapping(y => y.Current);
            altSource.AddMapping(ShapeElementPointMarker.ToolTipTextProperty, s => $"Потужність = {s.Power}");

            VoltAmperChart.AddLineGraph(altSource, new Pen(Brushes.Gold, 3), new SampleMarker(), new PenDescription("Вольт-амперна характеристика"));

            test.CalcExtremeValues();
            var res = test.GetGraphDots();
            test.GetMaxValues(res);
            test.FillFactor();
            test.ConvertingPowerEfficiency();


            var calcSource = new EnumerableDataSource<Dots>(res);
            calcSource.SetXMapping(x => x.Voltage);
            calcSource.SetYMapping(y => y.Current);
            calcSource.AddMapping(ShapeElementPointMarker.ToolTipTextProperty, s => $"Потужність = {s.Power}");
            VoltAmperChart.AddLineGraph(calcSource, new Pen(Brushes.Green, 3), new SampleMarker(), new PenDescription("Вольт-амперна характеристика"));

            var dotSource = new EnumerableDataSource<Dots>(new List<Dots>() { test.MaxPIV});
            dotSource.SetXMapping(x => x.Voltage);
            dotSource.SetYMapping(y => y.Current);
            dotSource.AddMapping(ShapeElementPointMarker.ToolTipTextProperty, s => $"Потужність = {s.Power}");
            VoltAmperChart.AddLineGraph(dotSource, new Pen(Brushes.Orange, 3), new SampleMarkerFinalDot(), new PenDescription("Вольт-амперна характеристика"));
            VoltAmperChart.FitToView();
            VoltAmperChart.InvalidateVisual();



            
        }
    }
}

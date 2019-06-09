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

namespace calculo_cuadrado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Rectangulo ElRectangulo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ElRectangulo = new Rectangulo { PuntoA_X = "0", PuntoA_Y = "0", PuntoB_X = "0", PuntoB_Y = "0",PuntoC_X = "0",PuntoC_Y = "0",PuntoD_X = "0",PuntoD_Y = "0"};
            this.DataContext = ElRectangulo;
        }

    }
}

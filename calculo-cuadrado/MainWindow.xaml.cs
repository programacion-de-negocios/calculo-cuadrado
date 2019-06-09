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
            //RECTANGULO DE EJEMPLO AL MOMENTO DE INICIAR EL PROGRAMA
            ElRectangulo = new Rectangulo { PuntoA_X = "1", PuntoA_Y = "2", PuntoB_X = "5", PuntoB_Y = "2",PuntoC_X = "5",PuntoC_Y = "1",PuntoD_X = "1",PuntoD_Y = "1"};
            this.DataContext = ElRectangulo;
        }

    }
}

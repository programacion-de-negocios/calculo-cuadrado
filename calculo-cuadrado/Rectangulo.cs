using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//usando el namespace necesario
using System.ComponentModel;

namespace calculo_cuadrado
{
    public class Rectangulo : INotifyPropertyChanged
    {
        private string puntoA_X;
        private string puntoA_Y;
        private string puntoB_X;
        private string puntoB_Y;
        private string puntoC_X;
        private string puntoC_Y;
        private string puntoD_X;
        private string puntoD_Y;

        private double baseRectangulo = 0;
        private double alturaRectangulo = 0;
        //PROPIEDADES PARA EL PUNTO A
        public string PuntoA_X
        {
            get { return puntoA_X; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoA_X = value;
                OnPropertyChanged("PuntoA_X");
                OnPropertyChanged("Perimetro");
            }
        }
        public string PuntoA_Y
        {
            get { return puntoA_Y; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoA_Y = value;
                OnPropertyChanged("PuntoA_Y");
                OnPropertyChanged("Perimetro");
            }
        }
        //PROPIEDADES PARA EL PUNTO B
        public string PuntoB_X
        {
            get { return puntoB_X; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoB_X = value;
                OnPropertyChanged("PuntoB_X");
                OnPropertyChanged("Perimetro");
            }
        }
        public string PuntoB_Y
        {
            get { return puntoB_Y; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoB_Y = value;
                OnPropertyChanged("PuntoB_Y");
                OnPropertyChanged("Perimetro");
            }
        }
        //PROPIEDADES PARA EL PUNTO C
        public string PuntoC_X
        {
            get { return puntoC_X; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoC_X = value;
                OnPropertyChanged("PuntoC_X");
                OnPropertyChanged("Perimetro");
            }
        }
        public string PuntoC_Y
        {
            get { return puntoC_Y; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoC_Y = value;
                OnPropertyChanged("PuntoC_Y");
                OnPropertyChanged("Perimetro");
            }
        }
        //PROPIEDADES PARA EL PUNTO D
        public string PuntoD_X
        {
            get { return puntoD_X; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoD_X = value;
                OnPropertyChanged("PuntoD_X");
                OnPropertyChanged("Perimetro");
            }
        }
        public string PuntoD_Y
        {
            get { return puntoD_Y; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) puntoD_Y = value;
                OnPropertyChanged("PuntoD_Y");
                OnPropertyChanged("Perimetro");
            }
        }
        private double Distancia(double x1,double x2, double y1,double y2)
        {
            double distancia;
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }

        private void VerificarRectangulo()
        {
            double base1,base2,altura1,altura2;
            base1 = Distancia(double.Parse(puntoA_X), double.Parse(puntoB_X), double.Parse(PuntoA_Y), double.Parse(PuntoB_Y));
            base2 = Distancia(double.Parse(puntoC_X), double.Parse(puntoD_X), double.Parse(PuntoC_Y), double.Parse(PuntoD_Y));
            altura1= Distancia(double.Parse(puntoA_X), double.Parse(puntoD_X), double.Parse(PuntoA_Y), double.Parse(PuntoD_Y));
            altura2 = Distancia(double.Parse(puntoB_X), double.Parse(puntoC_X), double.Parse(PuntoB_Y), double.Parse(PuntoC_Y));
            if(base1==base2 && altura1 == altura2)
            {
                
                BaseRectangulo = base1;
                AlturaRectangulo = altura1;
            }
           
        }
        public double BaseRectangulo
        {
            get
            { return baseRectangulo; }
            set
            { baseRectangulo = value; }
        }
        public double AlturaRectangulo
        {
            get { return alturaRectangulo; }
            set { alturaRectangulo = value; }
        }
        public string Perimetro
        {
           
            get {
                VerificarRectangulo();
                double perimetro;
                perimetro = 2 * BaseRectangulo + 2 * AlturaRectangulo;
                return perimetro.ToString();
            }
            set {
                VerificarRectangulo();
                double perimetro;
                perimetro = 2 * BaseRectangulo + 2 * AlturaRectangulo;
                perimetro.ToString();
                OnPropertyChanged("Perimetro");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}

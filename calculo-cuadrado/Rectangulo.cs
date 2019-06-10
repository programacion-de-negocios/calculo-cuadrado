using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//usando el namespace necesario
using System.ComponentModel;
using System.Windows;

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
                OnPropertyChanged("BaseRectangulo");
                OnPropertyChanged("AlturaRectangulo");
                if (VerificarAltura() != 0 || VerificarBase() != 0)
                {
                    OnPropertyChanged("Perimetro");
                    OnPropertyChanged("Area");
                }
                else {
                    Perimetro = "0";
                    Area = "0";
                    MessageBox.Show("NO SE PUEDE FORMAR NINGUN RECTANGULO, LAS COORDENADAS NO COINCIDEN");
                }
            }
        }
        //METODO PARA OBTENER LA DISTANCIA ENTRER DOS PUNTOS
        private double Distancia(double x1,double x2, double y1,double y2)
        {
            double distancia;
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }
        //METODO PARA VERIFICAR LA BASE DEL RECTANGULO
        public double VerificarBase()
        {
            double base1,base2;
            base1 = Distancia(double.Parse(puntoA_X), double.Parse(puntoB_X), double.Parse(PuntoA_Y), double.Parse(PuntoB_Y));
            base2 = Distancia(double.Parse(puntoC_X), double.Parse(puntoD_X), double.Parse(PuntoC_Y), double.Parse(PuntoD_Y));
            if(base1!=base2) base1 = 0;
            return base1;
        }
        //METODO PARA VERIFICAR LA ALTURA DEL RECTANGULO
        public double VerificarAltura()
        {
            double altura1, altura2;
            altura1 = Distancia(double.Parse(puntoA_X), double.Parse(puntoD_X), double.Parse(PuntoA_Y), double.Parse(PuntoD_Y));
            altura2 = Distancia(double.Parse(puntoB_X), double.Parse(puntoC_X), double.Parse(PuntoB_Y), double.Parse(PuntoC_Y));
            if (altura1 != altura2)
            {
                altura1 = 0;
               
            }
            return altura1;
        }
        //PROPIEDAD PARA OBTENER LA BASE DEL RECTANGUL
        public string BaseRectangulo
        {
            get{
                double labase = VerificarBase();
                return labase.ToString();
            }
            set{
                double labase = VerificarBase();
                labase.ToString();
                OnPropertyChanged("BaseRectangulo");
            }
        }
        //PROPIEDAD PARA OBTENER LA ALTURA DEL RECTANGULO
        public string AlturaRectangulo
        {
            get {
                double laaltura = VerificarAltura();
                return laaltura.ToString();
            }
            set {
                double laaltura = VerificarAltura();
                laaltura.ToString();
                OnPropertyChanged("AlturaRectangulo");
            }
        }
        //CALCULO PARA EL PERIMETRO DEL RECTANGULO
        public string Perimetro
        {
            get {
                double perimetro;
                perimetro = 2 * double.Parse(BaseRectangulo) + 2 * double.Parse(AlturaRectangulo);
                return perimetro.ToString();
            }
            set {
                double perimetro;
                perimetro = 2 * double.Parse(BaseRectangulo) + 2 * double.Parse(AlturaRectangulo);
                perimetro.ToString();
                OnPropertyChanged("Perimetro");
            }
        }
        //CALCULO PARA EL AREA DEL RECTANGULO
        public string Area
        {
            get
            {
                double elarea;
                elarea = double.Parse(BaseRectangulo) * double.Parse(AlturaRectangulo);
                return elarea.ToString();
            }
            set
            {
                double elarea;
                elarea = double.Parse(BaseRectangulo) * double.Parse(AlturaRectangulo);
                elarea.ToString();
                OnPropertyChanged("Area");
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

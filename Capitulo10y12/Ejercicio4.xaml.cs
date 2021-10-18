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

namespace Capitulo10y12
{
    /// <summary>
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        class Poligono
        {
            public int CAntidad;
            public int Medida;
            public int Angulo;
            public Poligono(int cantidad, int medida, int angulo)
            {
                CAntidad = cantidad;
                Medida = medida;
                Angulo = angulo;
            }
            public Poligono()
            {
                CAntidad = 0;
                Medida = 0;
                Angulo = 0;
            }
            public int Cantidad
            {
                get
                {
                    return CAntidad;
                }

                set
                {
                    if (value <= 0)
                    {
                        CAntidad = 1;
                    }
                    else
                    {
                        CAntidad = value;
                    }
                }
            }
            public int Medidas
            {
                get
                {
                    return Medida;
                }

                set
                {
                    if (value <= 0)
                    {
                        Medida = 1;
                    }
                    else
                    {
                        Medida = value;
                    }
                }
            }
            public int Angulos
            {
                get
                {
                    return Angulo;
                }

                set
                {
                    if (value <= 0)
                    {
                        Angulo = 1;
                    }
                    else
                    {
                        Angulo = value;
                    }
                }
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {Cantidad}\nMedidas de lados: {Medida}\n Angulos: {Angulo}");
                return sb.ToString();
            }
        }
        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono();
            poligono.Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Lados", " ", 50, 0));
            poligono.Medidas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de lados: ", "Medidas", " ", 50, 0));
            poligono.Angulos = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 50, 0));

            ResultadoTextBlock.Text = poligono.ToString();
        }
    }
}

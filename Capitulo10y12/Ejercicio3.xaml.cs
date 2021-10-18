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
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        class Poligono
        {
            public int Cantidad;
            public int Medidas;
            public int Angulos;
            public Poligono(int cantidad, int medida, int angulo)
            {
                Cantidad = cantidad;
                Medidas = medida;
                Angulos = angulo;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {Cantidad}\nMedidas de lados: {Medidas}\n Angulos: {Angulos}");
                return sb.ToString();
            }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Lados", " ", 30, 0)),
              Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de lados: ", "Medidas", " ", 30, 0)),
              Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 30, 0)));
            ResultadoTextBlock.Text = poligono.ToString();
        }
    }
}

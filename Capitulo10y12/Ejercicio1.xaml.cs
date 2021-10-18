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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        public class Inventario
        {
            public int Codigo;
            public float Precio;
            public string Producto;
            public string DescripcionProducto;
            public int Existencia;
          

            public Inventario(int codigo, float precio, string producto, string descripcion, int existencia)
            {
                Codigo = codigo;
                Precio = precio;
                Producto = producto;
                DescripcionProducto = descripcion;
                Existencia = existencia;
              
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo: {Codigo}\nPrecio:{Precio} \nProducto:  {Producto}\nDescripcion: " +
                    $"{DescripcionProducto}\nExistencia: {Existencia}");
                return sb.ToString();
            }
        }
        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            Inventario inventario = new Inventario(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del producto: ", "Codigo del Producto", " ", 50, 0)),
                Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Precio del producto: ", "Precio del Producto", " ", 50, 0)),
            Microsoft.VisualBasic.Interaction.InputBox($"Nombre del producto: ", "Nombre del Producto", " ", 50, 0),
              Microsoft.VisualBasic.Interaction.InputBox($"Descripcion del producto: ", "Descripcion del Producto", " ", 50, 0),
              Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Existencia del producto: ", "Existencia del Producto", " ", 50, 0)));
              
            ResultadoTextBlock.Text = inventario.ToString();
        }
    }
}

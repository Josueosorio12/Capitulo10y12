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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        class Estudiantes
        {
            public int Matricula;
            public string Nombre;
            public int Edad;
            public string Grado;
            public string Seccion;
            public Estudiantes(int matricula, string nombre, int edad, string grado, string seccion)
            {
                Matricula = matricula;
                this.Nombre = nombre;
                this.Edad = edad;
                this.Grado = grado;
                this.Seccion = seccion;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Matricula: {Matricula}\nNombre del Estudiante: " +
                    $"{Nombre}\nEdad: {Edad}\nGrado: {Grado}\nSeccion: {Seccion}");
                return sb.ToString();
            }
        }
        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Matricula del estudiante: ",
                "Matricula", " ", 50, 0)),Microsoft.VisualBasic.Interaction.InputBox($"Nombre del estudiante: ", "Nombre", " ", 30, 0),
              int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Edad del estudiante: ", "Edad", " ", 30, 0)),
              Microsoft.VisualBasic.Interaction.InputBox($"Grado del estudiante: ", "Grado", " ", 30, 0),
              Microsoft.VisualBasic.Interaction.InputBox($"Seccion del estudiante: ", "Seccion", " ", 30, 0));
            ResultadoTextBlock.Text = estudiantes.ToString();
        }
    }
}

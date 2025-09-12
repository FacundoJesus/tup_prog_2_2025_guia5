using Microsoft.VisualBasic.Devices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random azar = new Random();
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Apellidos = new List<string> { "Hernandez", "Saavedra", "Acosta","Jacob", "Heinze","Fischer","Campos" };
            List<string> Nombres = new List<string> { "Adriana", "Elizabet", "José", "María", "Ernesto", "Sebastian", "Julio", "Ester", "Ariel", "Betiana", "Silvina", "Ana", "Leandro", "Ayelen", "Daniela", "Miguel" };

            StringBuilder listado = new StringBuilder();
            int n;
            for (n = 0; n < 10000; n++)
            {
                int posNombre = azar.Next(Nombres.Count);
                int posApellido = azar.Next(Apellidos.Count);

                listado.AppendLine($"{Apellidos[posApellido]}, {Nombres[posNombre]}");
            }

            lsbResultado.Items.AddRange(listado.ToString().Split("\n"));
            lsbResultado.Items.Add($"Cantidad:{n}");
        }

    }
    
}

using Ejercicio3.Models;
using System.Text.RegularExpressions;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            #region Imprimir vehiculos y multas
            //lsbResumen.Items.AddRange(vehiculos.ToArray()); //vector de objetos - NO PUEDO LISTA DE STRING tampoco puedo TOSTRING

            Regex regex = new Regex(@""); //Armar la expresion regular
            Match match = regex.Match(tbXml.Text); // devuelve un objeto ocurrencia

            while (match.Success) {
                
                Vehiculo nuevoVehiculo = new Vehiculo();

                string objectXML = match.Value; // saco el 1er valor de esa ocurrencia
                if (nuevoVehiculo.Importar(objectXML))
                {
                    vehiculos.Sort();
                    int idx = vehiculos.BinarySearch(nuevoVehiculo);
                    if (idx > -1)
                    {
                        //vehiculos[idx].AgregarMulta(nuevoVehiculo.VerMulta(0));
                        for(int i = 0, i < nuevoVehiculo.CantidadMultas; i++)
                        {
                            vehiculos[idx].AgregarMulta(nuevoVehiculo.VerMulta(0));
                        }
                    }
                    else {
                        vehiculos.Add(nuevoVehiculo);
                    }  

                }
                match = match.NextMatch(); // siguiente match - si no devuelve, rompe el bucle
            }
            foreach(Vehiculo v in vehiculos)
            {
                lsbResumen.Items.Add(v);
            }
            #endregion
        }
    }
}

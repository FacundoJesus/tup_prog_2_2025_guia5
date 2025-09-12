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

            #region Importar vehiculos
            //Armar la expresion regular - El patron
            Regex regex = new Regex(@"<multa>[\s\S]*?</multa>", RegexOptions.IgnoreCase); 
            Match match = regex.Match(tbXml.Text); // devuelve un objeto ocurrencia

            
            while (match.Success) {

                Vehiculo nuevoVehiculo = new Vehiculo();

                string objectXML = match.Value; // saco el 1er valor de esa ocurrencia
                if (nuevoVehiculo.Importar(objectXML) == true)
                {
                    vehiculos.Sort();
                    int idx = vehiculos.BinarySearch(nuevoVehiculo);
                    if (idx > -1)
                    {
                        
                        for(int i = 0; i < nuevoVehiculo.CantidadMultas; i++) 
                        {
                            vehiculos[idx].AgregarMulta(nuevoVehiculo.VerMulta(i));
                        }
                    }
                    else {
                        vehiculos.Add(nuevoVehiculo);
                    }  

                }
                // siguiente match - si no devuelve, rompe el bucle
                match = match.NextMatch(); 
            }
            #endregion


            #region Imprimir vehiculos
            lsbResumen.Items.Clear();
            foreach(Vehiculo v in vehiculos)
            {
                lsbResumen.Items.Add(v.ToString().Trim());
            }
            
            lsbResumen.Items.Add($"Cantidad de Multas: {vehiculos.Count}");
            //lsbResumen.Items.Add($"Importe Total: {vehiculos.ImporteTotal}");
            // o ... lsbResumen.AddRange(vehiculos.ToArray());
            #endregion
        }
    }
}

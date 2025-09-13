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

            int cantMultas = 0;
            while (match.Success) {

                Vehiculo nuevoVehiculo = new Vehiculo();

                string objectXML = match.Value; // saco el 1er valor de esa ocurrencia

                if (nuevoVehiculo.Importar(objectXML) == true)
                {
                    cantMultas++;
                    vehiculos.Sort();
                    int idx = vehiculos.BinarySearch(nuevoVehiculo);
                    if (idx > -1) //Si ya existe la patente del auto...
                    {
                        
                        for(int i = 0; i < nuevoVehiculo.CantidadMultas; i++) 
                        {
                            vehiculos[idx].AgregarMulta(nuevoVehiculo.VerMulta(i)); //Le agrego la multa a ese auto
                        }

                    }
                    else //Si no existe la patente del auto...
                    { 
                        vehiculos.Add(nuevoVehiculo);
                    }  

                }
                
                match = match.NextMatch(); // siguiente match - si no devuelve, rompe el bucle
            }
            #endregion



            #region Imprimir vehiculos

            lsbResumen.Items.Clear();
            foreach(Vehiculo v in vehiculos)
            {
                lsbResumen.Items.Add(v.ToString().Trim());
            }
            // o ... lsbResumen.AddRange(vehiculos.ToArray());
            double totalRecaudacion = 0;
            foreach (Vehiculo v in vehiculos)
            {
                totalRecaudacion += v.ImporteTotal;
            }
            lsbResumen.Items.Add($"Cantidad de Multas: {cantMultas}");
            lsbResumen.Items.Add($"Importe Global: {totalRecaudacion:c2}");


            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Ejercicio3.Models
{
    public class Vehiculo : IComparable, IImportable
    {
        public string Patente { get; set; }

        public int CantidadMultas {
            get
            {
                return listaMultas.Count;
            }
        }

        private double total;
        public double ImporteTotal { 
            get
            {
                total = 0;
                foreach(Multa m in listaMultas)
                {
                    total += m.Importe;
                }
                return total;
            }
            set
            {
                total = value;
            }
        }


        private List<Multa> listaMultas = new List<Multa>();

        public Vehiculo() { }
        public Vehiculo(string patente)
        {
            this.Patente = patente;
        }

        public Multa VerMulta(int idx)
        {
            Multa multa = null;
            if (idx>= 0 &&  idx < listaMultas.Count)
            {
                multa = listaMultas[idx] as Multa;
            }
            return multa;    
        }

        public void AgregarMulta(Multa nuevaMulta)
        {
            listaMultas.Add(nuevaMulta);
        }


        public bool Importar(string xml)
        {
            Regex regex = new Regex(@"<patente>([\s\w]+?)</patente>", RegexOptions.IgnoreCase);
            Match matchPatente = regex.Match(xml);

            if (matchPatente.Groups.Count == 2) {                   
                this.Patente = matchPatente.Groups[1].Value;
                //Group[0].Value -> Es toda la etiqueta "<patente>ABC123</patente>"
                //Group[1].Value -> Es unicamente lo que esté dentro "ABC123" 
                //Group[2].Value -> No hay porque definí solo un grupo entre paréntesis en el regex.
            }
            else
            {
                return false;
            }

            //Llamo a Importar Multa. Para ello, debo crear un objeto.
            Multa nuevamulta = new Multa();
            AgregarMulta(nuevamulta);
            if(nuevamulta.Importar(xml) == true) {
                this.total += nuevamulta.Importe;
                return true;
            }
            return false;

        }

        
        public int CompareTo(object? obj)
        {
            Vehiculo nuevoVehiculo = obj as Vehiculo;
            if(nuevoVehiculo != null)
            {
                return this.Patente.CompareTo(nuevoVehiculo.Patente);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"Patente: {this.Patente} - Importe Total: {this.ImporteTotal:c2}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set
            { 
                CantidadMultas = value;
            }
        }

        public double ImporteTotal { 
            get
            {
                double total = 0;
                foreach(Multa m in listaMultas)
                {
                    total += m.Importe;
                }
                return total;
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
            return $"Patente: {this.Patente} - Importe Total: ${this.ImporteTotal:f2}";
        }
    }
}

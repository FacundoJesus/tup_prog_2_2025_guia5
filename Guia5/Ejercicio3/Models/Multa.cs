using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Multa:IImportable
    {
        public double Importe;

        public Multa()
        {

        }

        public Multa(double importe)
        {
            this.Importe = importe;
        }

        public bool Importar(string xml)
        {
            
        }

        public override string ToString()
        {
            return $"Importe:{this.Importe}";
              
        }
    }
}

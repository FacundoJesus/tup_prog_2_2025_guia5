using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Multa:IImportable
    {
        public double Importe { get; set; }

        public Multa()
        {

        }

        public Multa(double importe)
        {
            this.Importe = importe;
        }

        public override string ToString()
        {
            return $"Importe:{this.Importe}";
              
        }

        public bool Importar(string xml)
        {
            Regex regex = new Regex(@"<importe>([\w\s,]+?)</importe>", RegexOptions.IgnoreCase);
            Match match = regex.Match(xml);
            if(match.Success && match.Groups.Count == 2)
            {
                this.Importe = Convert.ToDouble(match.Groups[1].Value);
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class CuitRegexValidador:CuitsCharValidador
    {
        public CuitRegexValidador(string expresion):base(expresion) { }

        //Ej.Correcto : 21-32568526-3
        public override bool Validar()
        {
            Regex regex = new Regex(@"^\d{2}-\d{8}-\d{1}$");
            Match match = regex.Match(this.expresion);
            if(match.Success) {
                return true;
            }
            return false;
        }
    }
}

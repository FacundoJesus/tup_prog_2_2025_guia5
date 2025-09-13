using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PatenteNuevaRegexValidador:PatentesNuevasCharValidador
    {
        public PatenteNuevaRegexValidador(string expresion):base(expresion) { }

        //Ej correcto: AB 1234 CD
        public override bool Validar()
        {
            Regex regex = new Regex(@"^[A-Za-z]{2} \d{4} [A-Za-z]{2}$");
            Match match = regex.Match(this.expresion);
            if (match.Success) {
                return true;
            }
            return false;
        }
    }
}

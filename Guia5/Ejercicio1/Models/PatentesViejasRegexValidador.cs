using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PatentesViejasRegexValidador:PatentesViejasCharValidador
    {
        public PatentesViejasRegexValidador(string expresion):base(expresion) {}

        //Ej correcto: ABC 123

        public override bool Validar()
        {
            Regex regex = new Regex(@"^[A-Z]{3} \d{3}$");
            Match match = regex.Match(this.expresion);
            if (match.Success) {
                return true;
            }
            return false;
        }
    }
}

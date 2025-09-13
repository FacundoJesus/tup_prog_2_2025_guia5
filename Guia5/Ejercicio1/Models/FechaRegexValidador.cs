using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class FechaRegexValidador:FechaCharValidador
    {
        public FechaRegexValidador(string expresion):base(expresion) { }

        //Ej.Correcto: 23/1/2024 o 23/01/2024

        public override bool Validar()
        {
            Regex regex = new Regex(@"^\d{2}/\d{1,2}/\d{4}$");
            Match match = regex.Match(this.expresion);
            if (match.Success) {
                return true;
            }
            return false;
        }
    }
}

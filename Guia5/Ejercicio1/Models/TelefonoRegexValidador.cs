using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class TelefonoRegexValidador:TelefonoCharValidador
    {
        public TelefonoRegexValidador(string expresion) : base(expresion) { }


        //Ej correcto: 2324-2456556 o 343-4817427
        public virtual bool Validar()
        {
            Regex regex = new Regex(@"^\d{ 3, 4 } -\d{ 7}$");
            Match match = regex.Match(expresion);
            if(match.Success)
            {
                return true;
            }
            return false;
            
        }
    }
}

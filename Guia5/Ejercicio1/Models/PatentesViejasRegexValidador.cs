using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PatentesViejasRegexValidador:PatentesViejasCharValidador
    {
        public PatentesViejasRegexValidador(string expresion):base(expresion) {}

        public override bool Validar()
        {
            return true;
        }
    }
}

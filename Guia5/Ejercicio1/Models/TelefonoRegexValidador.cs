using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class TelefonoRegexValidador:TelefonoCharValidador
    {
        public TelefonoRegexValidador(string expresion) : base(expresion) { }

        public virtual bool Validar()
        {
            return true;
        }
    }
}

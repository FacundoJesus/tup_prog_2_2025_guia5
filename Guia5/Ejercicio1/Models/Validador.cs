using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Validador
    {
        protected string expresion;
        protected string MENSAJE_CORRECTO = "";
        protected string MENSAJE_INCORRECTO = "";
        public Validador(string expresion)
        {
            this.expresion = expresion;
        }

        public virtual string VerMensaje()
        {
            if(Validar())
            {
                return MENSAJE_CORRECTO;
            }
            return MENSAJE_INCORRECTO;
        }

        public abstract bool Validar();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PatentesNuevasCharValidador : Validador
    {
        public PatentesNuevasCharValidador(string expresion):base(expresion) {
            this.MENSAJE_CORRECTO = "Número de Patente Nueva Correcta!";
            this.MENSAJE_INCORRECTO = "Número de Patente Nueva Incorrecta!";
        }

        public override string VerMensaje()
        {
            if(Validar())
            {
                return MENSAJE_CORRECTO;
            }
            return MENSAJE_INCORRECTO;
        }

        public override bool Validar()
        {
            // Ej Correcto: AB 1234 CD
            // 5 GRUPOS
            int cantGrupo1 = 0;
            int cantEspaciosA = 0;
            int cantGrupo3 = 0;
            int cantEspacioB = 0;
            int cantGrupo5 = 0;

            for(int i = 0; i<this.expresion.Length;i++)
            {
                if (char.IsLetter(expresion[i]) && cantGrupo1 == i) {
                    cantGrupo1++;
                }
                else
                if()
                {

                }
            }

        }
    }
}

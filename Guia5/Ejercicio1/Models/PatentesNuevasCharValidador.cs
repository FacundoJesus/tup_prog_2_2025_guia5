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
            int cantEspacioA = 0;
            int cantGrupo2 = 0;
            int cantEspacioB = 0;
            int cantGrupo3 = 0;

            for(int i = 0; i<this.expresion.Length;i++)
            {
                if (char.IsLetter(expresion[i]) && cantGrupo1 == i) {
                    cantGrupo1++;
                }
                else
                if (expresion[i] == ' ' && cantGrupo1 + cantEspacioA == i)
                {
                    cantEspacioA++;
                }
                else
                if (char.IsNumber(expresion[i]) && cantGrupo1+cantEspacioA+cantGrupo2==i)
                {
                    cantGrupo2++;
                }
                else
                if (expresion[i] == ' ' && cantGrupo1+cantEspacioA+cantGrupo2+cantEspacioB==i)
                { 
                    cantEspacioB++;
                }
                else
                if (char.IsLetter(expresion[i]) && cantGrupo1+cantEspacioA+cantGrupo2+cantEspacioB+cantGrupo3==i)
                {
                    cantGrupo3++;
                }

            }
            if(cantGrupo1 == 2 && cantEspacioA == 1 && cantGrupo2 == 4 && cantEspacioB == 1 && cantGrupo3==2)
            {
                return true;
            }
            return false;

        }
    }
}

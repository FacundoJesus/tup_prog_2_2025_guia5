using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PatentesViejasCharValidador:Validador
    {
        public PatentesViejasCharValidador(string expresion):base(expresion) {
            this.MENSAJE_CORRECTO = "Número de Patente Vieja Correcta!";
            this.MENSAJE_INCORRECTO = "Número de Patente Vieja Incorrecta!";
        }

        public virtual string VerMensaje()
        {
            if(Validar())
            {
                return this.MENSAJE_CORRECTO;
            }
            return this.MENSAJE_INCORRECTO;
        }

        public override bool Validar()
        {
            // Ej: ABC 123
            int cantGrupo1 = 0;
            int cantEspacios = 0; // Solo 1 espacio es correcto
            int cantGrupo2 = 0;
            for (int i =0; i<this.expresion.Length;i++) {
                if (char.IsLetter(expresion[i]) && cantGrupo1==i)
                {
                    cantGrupo1++;
                }
                else
                if (expresion[i] == ' ' && cantGrupo1+cantEspacios==i) {
                    cantEspacios++;

                }
                else
                if (char.IsNumber(expresion[i]) && cantGrupo1+cantEspacios+cantGrupo2 == i)
                {
                    cantGrupo2++;
                }
            }

            if(cantGrupo1==3 && cantEspacios==1 && cantGrupo2==3 && cantGrupo1+cantEspacios+cantGrupo2==expresion.Length)
            {
                return true;
            }
            return false;
        }
    }
}

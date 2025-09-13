using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class FechaCharValidador : Validador
    {
        public FechaCharValidador(string expresion) : base(expresion)
        {
            this.MENSAJE_CORRECTO = "Número de Fecha Correcto!";
            this.MENSAJE_INCORRECTO = "Número de Fecha Incorrecto!";
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
            //Ej. Correcto: 23/1/2024 o... 23/01/2024
            //5 Grupos
            int cantGrupo1 = 0;
            int cantGrupo2 = 0;
            int cantGrupo3 = 0;
            int cantGrupo4 = 0;
            int cantGrupo5 = 0;
            for(int i = 0;i < this.expresion.Length;i++) {
                if (char.IsNumber(expresion[i]) && cantGrupo1==i)
                {
                    cantGrupo1++;
                }
                else
                if (expresion[i] == '/' && cantGrupo1+cantGrupo2==i)
                {
                    cantGrupo2++;
                }
                else
                if (char.IsNumber(expresion[i]) && cantGrupo1+cantGrupo2+cantGrupo3 == i)
                {
                    cantGrupo3++;
                }
                else
                if (expresion[i] == '/' && cantGrupo1+cantGrupo2+cantGrupo3+cantGrupo4 == i)
                {
                    cantGrupo4++;
                }
                else
                if (char.IsNumber(expresion[i]) && cantGrupo1+cantGrupo2+cantGrupo3+cantGrupo4+cantGrupo5 == i)
                {
                    cantGrupo5++;
                }
            }
            if(cantGrupo1 == 2 && cantGrupo2 == 1 &&(cantGrupo3 == 2 || cantGrupo3==1) && cantGrupo4 == 1 && cantGrupo5 == 4)
            {
                return true;
            }
            return false;
        }
    }
}

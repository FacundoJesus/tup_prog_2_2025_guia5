using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class CuitsCharValidador : Validador
    {
        public CuitsCharValidador(string expresion):base(expresion)
        {
            this.MENSAJE_CORRECTO = "Número de CUIT Correcto!";
            this.MENSAJE_INCORRECTO = "Número de CUIT Incorrecto!";
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
            //Ej correcto: 20-28464555-2
            //5 Grupos
            int cantGrupo1 = 0;
            int cantGuiones = 0;
            int cantGrupo2 = 0;
            int cantGuiones2 = 0;
            int cantGrupo3 = 0;
            for (int i =0;i<this.expresion.Length;i++)
            {
                if (char.IsNumber(expresion[i]) && cantGrupo1==i)
                {
                    cantGrupo1++;
                }
                else
                if (expresion[i] == '-' && cantGrupo1+cantGuiones==i)
                {
                    cantGuiones++;
                }
                else
                if (char.IsNumber(expresion[i]) && cantGrupo1+cantGuiones+cantGrupo2 == i)
                {
                    cantGrupo2++;
                }
                else
                if(expresion[i] == '-' && cantGrupo1 + cantGuiones + cantGrupo2 + cantGuiones2 == i)
                {
                    cantGuiones2++;
                }
                else
                if (char.IsNumber(expresion[i]) && cantGrupo1+cantGuiones+cantGrupo2+cantGuiones2+cantGrupo3 == i)
                {
                    cantGrupo3++;
                }
            }
            if(cantGrupo1==2 && cantGuiones == 1 && cantGrupo2==8 && cantGuiones2==1 && cantGrupo3 ==1)
            {
                return true;
            }
            return false;
        }
    }
}

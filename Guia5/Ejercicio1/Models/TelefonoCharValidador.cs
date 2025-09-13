using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class TelefonoCharValidador : Validador
    {
        public TelefonoCharValidador(string expresion):base(expresion) {
            this.MENSAJE_CORRECTO = "Número de Teléfono Correcto!";
            this.MENSAJE_INCORRECTO = "Número de Teléfono Incorrecto!";
        }

        public override string VerMensaje()
        {
            if (Validar())
            {
                return MENSAJE_CORRECTO;
            }
            return MENSAJE_INCORRECTO;
        }

        
        public override bool Validar()
        {
            //Divido 3 grupos
            int cantPrefijos = 0; // 343
            int cantGuiones = 0;  // -
            int cantSufijos = 0;  // 5129365
            for(int i=0; i<this.expresion.Length;i++) {

                if (char.IsNumber(expresion[i]) && cantPrefijos == i){
                    cantPrefijos++;
                }
                else 
                if (expresion[i] == '-' && cantPrefijos+cantGuiones == i) {
                    cantGuiones++;
                }
                else
                if (char.IsNumber(expresion[i]) && cantPrefijos + cantGuiones + cantSufijos == i){
                    cantSufijos++;
                }
            }

            //Validacion Final
            if ((cantPrefijos == 3 || cantPrefijos == 4 && cantGuiones == 1 && cantSufijos == 7) && cantPrefijos + cantGuiones + cantSufijos == expresion.Length)
            {
                return true;
            }
            return false;
            
        }
    }
}

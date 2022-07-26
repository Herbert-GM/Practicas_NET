using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcu2.clases;

namespace Calcu2.modelo
{
    internal class Operacion
    {
        public int CalcularX(int n1, int n2, string operacion)
        {   
            
            switch(operacion)
            {
                case "":
                    return 0;

                case Constantes.OperacionSuma:
                    return n1 + n2;

                case Constantes.OperacionResta:
                    return n1 - n2;

                case Constantes.OperacionMultiplicar:
                    return n1 * n2;

                default:
                    return 0;
            }
            
        }


    }
}

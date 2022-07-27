using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu2.clases
{
    internal class Validacion
    {
        public bool validarNumero(int NValidar, int DatoComparar)
        {
            if (NValidar > DatoComparar)
            {
                return true;
            }
            return false;
        }

    }
}

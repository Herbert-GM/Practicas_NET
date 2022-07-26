using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDota.Modelo
{
    internal class Validaciones
    {
        public bool ValidarDato(int criterio1, int criterio2)
        {
            if (criterio1 > criterio2)
            {
                return true;
            }
            return false;
        }
    }
}

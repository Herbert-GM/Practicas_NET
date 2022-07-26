using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu2.clases
{
    internal class Mensaje
    {         
        public string ConstruirCadena2(List<string> arrCadenas)
        {
            string CadenaCompleta = string.Empty;

            foreach(string str in arrCadenas)
            {
                CadenaCompleta = CadenaCompleta + str + "\n";
            }

            return CadenaCompleta;
        }
        
    }
}

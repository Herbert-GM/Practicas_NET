using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDota.Clases
{
    internal class Medalla
    {
        public string CalcularMedalla(int MMR)
        {
            if(MMR >= 9000)
            {
                return "INMORTAL TOP";
            }
            else if(MMR >= 8000)
            {
                return "Inmortal";
            }
            else if (MMR >= 7000)
            {
                return "Divine";
            }
            else if (MMR >= 6000)
            {
                return "Ancestro";
            }
            else if (MMR >= 5000)
            {
                return "Leyenda";
            }
            else if (MMR >= 4000)
            {
                return "Arconte";
            }
            else if (MMR >= 3000)
            {
                return "Cruzado";
            }
            else if (MMR >= 2000)
            {
                return "Guardian";
            }
            else  
            {
                return "Heraldo";
            }
        }

        public int MMRxROL(int MMR, bool sumarOrestar)
        {
            if (MMR >= 9000)
            {
                //if (sumarOrestar)
                //{
                //    return 100 + MMR;
                //}
                return sumarOrestar ? 100 + MMR : MMR;
            }
            else if (MMR >= 8000)
            {
                if (sumarOrestar)
                {
                    return 800 + MMR;
                }
                return MMR;
            }
            else if (MMR >= 7000)
            {
                if (sumarOrestar)
                {
                    return 200 + MMR;
                }
                return MMR;
            }
            else if (MMR >= 6000)
            {
                if (sumarOrestar)
                {
                    return 250 + MMR;
                }
                return MMR;
            }
            else if (MMR >= 5000)
            {
                if (sumarOrestar)
                {
                    return 300 + MMR;
                }
                return MMR;
            }
            else if (MMR >= 4000)
            {
                if (sumarOrestar)
                {
                    return 350 + MMR;
                }
                return MMR;
            }
            else if (MMR >= 3000)
            {
                if (sumarOrestar)
                {
                    return 400 + MMR;
                }
                return MMR;
            }
            else if (MMR >= 2000)
            {
                if (sumarOrestar)
                {
                    return 450 + MMR;
                }
                return MMR;
            }
            else
            {
                if (sumarOrestar)
                {
                    return 500 + MMR;
                }
                return MMR;
            }
        }

        public int MMRxROL(int MMR, bool sumarOrestar, string iDcheckBox)
        {
            if (iDcheckBox == "HC" || iDcheckBox == "MID" || iDcheckBox == "Support")
            {
                if (MMR >= 9000)
                {
                    return sumarOrestar ? 100 + MMR : MMR;
                }
                else if (MMR >= 8000)
                {
                    return sumarOrestar ? 150 + MMR : MMR;
                }
                else if (MMR >= 7000)
                {
                    return sumarOrestar ? 200 + MMR : MMR;
                }
                else if (MMR >= 6000)
                {
                    return sumarOrestar ? 250 + MMR : MMR;
                }
                else if (MMR >= 5000)
                {
                    return sumarOrestar ? 300 + MMR : MMR;
                }
                else if (MMR >= 4000)
                {
                    return sumarOrestar ? 350 + MMR : MMR;
                }
                else if (MMR >= 3000)
                {
                    return sumarOrestar ? 400 + MMR : MMR;
                }
                else if (MMR >= 2000)
                {
                    return sumarOrestar ? 450 + MMR : MMR;
                }
                else
                {
                    return sumarOrestar ? 500 + MMR : MMR;
                }
            }
            return 0;
        }
    }
}

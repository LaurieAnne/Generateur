using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class HelicoSecours : Vehicule
    {
        public HelicoSecours(string p_nom, int p_KMH, int p_tempsMain)
            : base(p_nom, p_KMH, p_tempsMain, ConsoleColor.Blue)
        {

        }
    }
}

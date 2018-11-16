using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class AvionCiterne : Vehicule
    {
        int m_tempsChargement; //Temps de chargement
        int m_tempsLargage; //Temps de largage

        public AvionCiterne(string p_nom, int p_KMH, int p_tempsMain, int p_tempsCharg, int p_tempsLarg) 
            : base(p_nom, p_KMH, p_tempsMain, ConsoleColor.Blue)
        {
            m_tempsChargement = p_tempsCharg;
            m_tempsLargage = p_tempsLarg;
        }
    }
}

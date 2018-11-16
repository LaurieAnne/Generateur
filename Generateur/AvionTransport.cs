using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public abstract class AvionTransport : Vehicule
    {
        int m_tempsEmbarquement; //Temps d'embarquement
        int m_tempsDebarquement; //Temps de débarquement

        public AvionTransport(string p_nom, int p_KMH, int p_tempsMain, int p_tempsEmb, int p_tempsDeb, ConsoleColor p_couleur) 
            : base(p_nom, p_KMH, p_tempsMain, p_couleur)
        {
            m_tempsEmbarquement = p_tempsEmb;
            m_tempsDebarquement = p_tempsDeb;
        }
    }
}

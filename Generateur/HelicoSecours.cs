using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class HelicoSecours : Vehicule
    {
        public HelicoSecours(string p_nom, int p_KMH, int p_tempsMain, PosCarte p_posAeroport) //Constructeur
            : base(p_nom, p_KMH, p_tempsMain, Color.Red, p_posAeroport)
        {

        }

        public HelicoSecours() : base()
        {

        }

        public override string ToString() //ToString
        {
            string vehicule;
            vehicule = m_nom + " (Secours), KM/H: " + m_KMH + ", Maintenance: " + m_tempsMaintenance;
            return vehicule;
        }
    }
}

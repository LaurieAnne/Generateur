using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class AvionObservateur : Vehicule
    {
        public AvionObservateur(string p_nom, int p_KMH, int p_tempsMain, PosCarte p_posAeroport) //Constructeur
            : base(p_nom, p_KMH, p_tempsMain, Color.Gray, p_posAeroport)
        {

        }

        public AvionObservateur() : base()
        {

        }

        public override string ToString() //ToString
        {
            string vehicule;
            vehicule = m_nom + " (Observateur), KM/H: " + m_KMH + ", Maintenance: " + m_tempsMaintenance;
            return vehicule;
        }
    }
}

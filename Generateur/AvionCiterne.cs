using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class AvionCiterne : Vehicule
    {
        int m_tempsChargement; //Temps de chargement
        int m_tempsLargage; //Temps de largage

        public AvionCiterne(string p_nom, int p_KMH, int p_tempsMain, int p_tempsCharg, int p_tempsLarg, PosCarte p_posAeroport) //Constructeur
            : base(p_nom, p_KMH, p_tempsMain, Color.Yellow, p_posAeroport)
        {
            m_tempsChargement = p_tempsCharg;
            m_tempsLargage = p_tempsLarg;
        }

        public AvionCiterne() : base()
        {

        }

        public int Chargement
        {
            get { return m_tempsChargement; }
            set { m_tempsChargement = value; }
        }

        public int Largage
        {
            get { return m_tempsLargage; }
            set { m_tempsLargage = value; }
        }

        public override string ToString() //ToString
        {
            string vehicule;
            vehicule = m_nom + " (Pompier), KM/H: " + m_KMH + ", Maintenance: " + m_tempsMaintenance;
            vehicule += ", Chargement: " + m_tempsChargement + ", Largage: " + m_tempsLargage;
            return vehicule;
        }

        public override void modifierVehicule(string p_nom, int[] p_params) //Modifier un véhicule
        {
            m_nom = p_nom;
            m_KMH = p_params[0];
            m_tempsMaintenance = p_params[1];
            m_tempsChargement = p_params[2];
            m_tempsLargage = p_params[3];
        }
    }
}

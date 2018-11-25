using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class AvionPassagers : AvionTransport
    {
        public AvionPassagers(string p_nom, int p_KMH, int p_tempsMain, int p_tempsEmb, int p_tempsDeb, PosCarte p_posAeroport) //Constructeur
            : base(p_nom, p_KMH, p_tempsMain, p_tempsEmb, p_tempsDeb, Color.Green, p_posAeroport)
        {

        }

        public AvionPassagers() : base()
        {

        }

        public override string ToString() //ToString
        {
            string vehicule;
            vehicule = m_nom + " (Passagers), KM/H: " + m_KMH + ", Maintenance: " + m_tempsMaintenance;
            vehicule += ", Embarquement: " + m_tempsEmbarquement + ", Débarquement: " + m_tempsDebarquement;
            return vehicule;
        }

        public override void modifierVehicule(string p_nom, int[] p_params) //Modifier un véhicule
        {
            m_nom = p_nom;
            m_KMH = p_params[0];
            m_tempsMaintenance = p_params[1];
            m_tempsEmbarquement = p_params[2];
            m_tempsDebarquement = p_params[3];
        }
    }
}

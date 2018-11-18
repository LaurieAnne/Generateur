using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public abstract class Vehicule
    {
        protected string m_nom; //Nom
        protected int m_KMH; //Le nombre de KM à l'heure
        protected int m_tempsMaintenance; //Temps de maintenance
        protected ConsoleColor m_couleur; //Couleur

        public Vehicule(string p_nom, int p_KMH, int p_tempsMain, ConsoleColor p_couleur) //Constructeur
        {
            m_nom = p_nom;
            m_KMH = p_KMH;
            m_tempsMaintenance = p_tempsMain;
            m_couleur = p_couleur;
        }

        public override string ToString() //ToString
        {
            string vehicule;
            vehicule = m_nom + " (Véhicule), KM/H: " + m_KMH + ", Maintenance: " + m_tempsMaintenance;
            return vehicule;
        }

        public virtual void modifierVehicule(string p_nom, int[] p_params) //Modifier un véhicule
        {
            m_nom = p_nom;
            m_KMH = p_params[0];
            m_tempsMaintenance = p_params[1];
        }
    }
}

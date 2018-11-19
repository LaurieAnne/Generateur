using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class Aeroport
    {
        private string m_nom; //Nom
        private int m_minPassagers; //Minimum de passagers
        private int m_maxPassagers; //Maxiumum de passagers
        private int m_minMarchandises; //Minimum de marchandises
        private int m_maxMarchandises; //Maximum de marchandises
        private List<Vehicule> m_vehicules; //Liste de véhicules
        private PosCarte m_pos; //Emplacement de l'aéroport

        public Aeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch) //Constructeur
        {
            m_nom = p_nom;
            m_minPassagers = p_minPass;
            m_maxPassagers = p_maxPass;
            m_minMarchandises = p_minMarch;
            m_maxMarchandises = p_maxMarch;
            m_vehicules = new List<Vehicule>();
            m_pos = null;
        }

        public Aeroport()
        {

        }

        public List<Vehicule> ListeVehicules
        {
            get { return m_vehicules; }
        }

        public string Nom
        {
            get { return m_nom; }
        }

        public int MinPass
        {
            get { return m_minPassagers; }
        }

        public int MaxPass
        {
            get { return m_maxPassagers; }
        }

        public int MinMarch
        {
            get { return m_minMarchandises; }
        }

        public int MaxMarch
        {
            get { return m_maxMarchandises; }
        }

        public PosCarte Pos
        {
            get { return m_pos; }
        }

        public override string ToString() //ToString
        {
            string aeroport;
            aeroport = m_nom + ", Min: " + m_minPassagers + ", Max: " + m_maxPassagers + ", Min: " + m_minMarchandises + ", Max: " + m_maxMarchandises;
            return aeroport;
        }

        public string[] obtenirVehicules() //Obtenir tous les véhicules
        {
            string[] vehicules = new string[m_vehicules.Count];

            for (int i = 0; i < m_vehicules.Count; i++)
            {
                vehicules[i] = m_vehicules[i].ToString();
            }

            return vehicules;
        }

        public void modifierAeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch) //Modifier un aéroport
        {
            m_nom = p_nom;
            m_minPassagers = p_minPass;
            m_maxPassagers = p_maxPass;
            m_minMarchandises = p_minMarch;
            m_maxMarchandises = p_maxMarch;
        }

        public void ajouterVehicule(Vehicule p_vehicule) //Ajouter un véhicule
        {
            m_vehicules.Add(p_vehicule);
        }

        public void modifierVehicule(string p_nom, int[] p_params, int p_vehicule) //Modifier un véhicule
        {
            m_vehicules[p_vehicule].modifierVehicule(p_nom, p_params);
        }

        public void supprimerVehicule(int p_vehicule) //Supprimer un véhicule
        {
            m_vehicules.RemoveAt(p_vehicule);
        }
    }
}

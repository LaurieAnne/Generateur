using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class Scenario
    {
        private List<Aeroport> m_aeroports; //Liste d'aéroports

        public Scenario() //Constructeur
        {
            m_aeroports = new List<Aeroport>();
        }

        public string[] obtenirAeroports() //Obtenir tous les aéroports
        {
            string[] aeroports = new string[m_aeroports.Count];

            for (int i = 0; i < m_aeroports.Count; i++)
            {
                aeroports[i] = m_aeroports[i].ToString();
            }

            return aeroports;
        }

        public string[] obtenirVehicules(int p_aeroport) //Obtenir tous les véhicules d'un aéroport
        {
            string[] vehicules = m_aeroports[p_aeroport].obtenirVehicules();
            return vehicules;
        }

        public void ajouterAeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch) //Ajouter un aéroport
        {
            Aeroport aeroport = new Aeroport(p_nom, p_minPass, p_maxPass, p_minMarch, p_maxMarch); //Nouvel aéroport
            m_aeroports.Add(aeroport);
        }

        public void ajouterVehicule(string p_nom, int p_KMH, int p_tempsMain, int p_type, int p_aeroport) //Ajouter un véhicule
        {
            Vehicule vehicule; //Nouveau véhicule

            if (p_type == 0)
            {
                vehicule = new AvionObservateur(p_nom, p_KMH, p_tempsMain); //Type observateur
            }
            else
            {
                vehicule = new HelicoSecours(p_nom, p_KMH, p_tempsMain); //Type secours
            }

            m_aeroports[p_aeroport].ajouterVehicule(vehicule);
        }

        public void ajouterVehicule(string p_nom, int p_KMH, int p_tempsMain, int p_tempsEmbOuCharg, int p_tempsDebOuLarg, int p_type, int p_aeroport) //Ajouter un véhicule
        {
            Vehicule vehicule; //Nouveau véhicule

            if (p_type == 2)
            {
                vehicule = new AvionPassagers(p_nom, p_KMH, p_tempsMain, p_tempsEmbOuCharg, p_tempsDebOuLarg); //Type passagers
            }
            else if (p_type == 3)
            {
                vehicule = new AvionMarchandises(p_nom, p_KMH, p_tempsMain, p_tempsEmbOuCharg, p_tempsDebOuLarg); //Type marchandises
            }
            else
            {
                vehicule = new AvionCiterne(p_nom, p_KMH, p_tempsMain, p_tempsEmbOuCharg, p_tempsDebOuLarg); //Type pompier
            }

            m_aeroports[p_aeroport].ajouterVehicule(vehicule);
        }
    }
}

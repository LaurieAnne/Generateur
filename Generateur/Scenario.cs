using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class Scenario
    {
        List<Aeroport> m_aeroports; //Liste d'aéroports

        public Scenario() //Constructeur
        {
            m_aeroports = new List<Aeroport>();
        }

        public void ajouterAeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch)
        {
            Aeroport aeroport = new Aeroport(p_nom, p_minPass, p_maxPass, p_minMarch, p_maxMarch);
            m_aeroports.Add(aeroport);
        }

        public void ajouterVehicule(string p_nom, int p_KMH, int p_tempsMain, bool p_obs, int p_aeroport)
        {
            Vehicule vehicule;
            if (p_obs)
                vehicule = new AvionObservateur(p_nom, p_KMH, p_tempsMain);
            else
                vehicule = new HelicoSecours(p_nom, p_KMH, p_tempsMain);
            m_aeroports[p_aeroport].ajouterVehicule(vehicule);
        }

        public void ajouterVehicule(string p_nom, int p_KMH, int p_tempsMain, int p_tempsEmb, int p_tempsDeb, bool p_pass, int p_aeroport)
        {
            Vehicule vehicule;
            if (p_pass)
                vehicule = new AvionPassagers(p_nom, p_KMH, p_tempsMain, p_tempsEmb, p_tempsDeb);
            else
                vehicule = new AvionMarchandises(p_nom, p_KMH, p_tempsMain, p_tempsEmb, p_tempsDeb);
            m_aeroports[p_aeroport].ajouterVehicule(vehicule);
        }

        public void ajouterVehicule(string p_nom, int p_KMH, int p_tempsMain, int p_tempsCharg, int p_tempsLarg, int p_aeroport)
        {
            Vehicule vehicule;
            vehicule = new AvionCiterne(p_nom, p_KMH, p_tempsMain, p_tempsCharg, p_tempsLarg);
            m_aeroports[p_aeroport].ajouterVehicule(vehicule);
        }
    }
}

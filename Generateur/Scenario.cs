using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Generateur
{
    [XmlRoot]
    public class Scenario
    {
        private List<Aeroport> m_aeroports; //Liste d'aéroports

        public Scenario() //Constructeur
        {
            m_aeroports = new List<Aeroport>();
        }

        public List<Aeroport> ListeAeroports
        {
            get { return m_aeroports; }
            set { m_aeroports = value; }
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
            Usine usine = Usine.obtenirUsine();
            Aeroport aeroport = usine.creerAeroport(p_nom, p_minPass, p_maxPass, p_minMarch, p_maxMarch);
            m_aeroports.Add(aeroport);
        }

        public void modifierAeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch, int p_aeroport) //Modifier un aéroport
        {
            m_aeroports[p_aeroport].modifierAeroport(p_nom, p_minPass, p_maxPass, p_minMarch, p_maxMarch);
        }

        public void supprimerAeroport(int p_aeroport) //Supprimer un aéroport
        {
            m_aeroports.RemoveAt(p_aeroport);
        }

        public void ajouterVehicule(string p_nom, int[] p_params, int p_type, int p_aeroport) //Ajouter un véhicule
        {
            Usine usine = Usine.obtenirUsine();
            Vehicule vehicule = usine.creerVehicule(p_nom, p_params, p_type);
            m_aeroports[p_aeroport].ajouterVehicule(vehicule);
        }

        public void modifierVehicule(string p_nom, int[] p_params, int p_vehicule, int p_aeroport) //Modifier un véhicule
        {
            m_aeroports[p_aeroport].modifierVehicule(p_nom, p_params, p_vehicule);
        }

        public void supprimerVehicule(int p_aeroport, int p_vehicule) //Supprimer un véhicule
        {
            m_aeroports[p_aeroport].supprimerVehicule(p_vehicule);
        }

        public void genererScenario(string p_nom) //Générer le scénario
        {
            XmlSerializer xs = new XmlSerializer(typeof(Scenario));
            string path = "..\\..\\..\\" + p_nom + ".xml";
            using (StreamWriter sw = new StreamWriter(path))
            {
                xs.Serialize(sw, this);
                sw.Close();
            }
        }
    }
}

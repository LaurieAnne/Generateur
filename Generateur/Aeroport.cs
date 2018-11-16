using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class Aeroport
    {
        string m_nom; //Nom
        int m_minPassagers; //Minimum de passagers
        int m_maxPassagers; //Maxiumum de passagers
        int m_minMarchandises; //Minimum de marchandises
        int m_maxMarchandises; //Maximum de marchandises
        List<Vehicule> m_vehicules; //Liste de véhicules
        PosCarte m_pos; //Emplacement de l'aéroport

        public Aeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch)
        {
            m_nom = p_nom; 
            m_minPassagers = p_minPass; 
            m_maxPassagers = p_maxPass;
            m_minMarchandises = p_minMarch;
            m_maxMarchandises = p_maxMarch;
            m_vehicules = new List<Vehicule>();
        }

        public void ajouterVehicule(Vehicule p_vehicule)
        {
            m_vehicules.Add(p_vehicule);
        }
    }
}

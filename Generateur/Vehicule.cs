using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public abstract class Vehicule
    {
        string m_nom; //Nom
        int m_KMH; //Le nombre de KM à l'heure
        int m_tempsMaintenance; //Temps de maintenance
        ConsoleColor m_couleur; //Couleur

        public Vehicule(string p_nom, int p_KMH, int p_tempsMain, ConsoleColor p_couleur)
        {
            m_nom = p_nom;
            m_KMH = p_KMH;
            m_tempsMaintenance = p_tempsMain;
            m_couleur = p_couleur;
        }
    }
}

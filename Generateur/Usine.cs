using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public sealed class Usine
    {
        private static Usine m_usine = null; //Usine
        
        private Usine()
        {

        }

        public static Usine obtenirUsine() //Obtenir l'usine
        {
            if (m_usine == null)
            {
                m_usine = new Usine();
            }
            return m_usine;
        }

        public Vehicule creerVehicule(string p_nom, int[] p_params, int p_type, PosCarte p_posAeroport) //Créer un objet véhicule
        {
            Vehicule vehicule = null; //Véhicule

            if (p_type == 0)
            {
                vehicule = new AvionObservateur(p_nom, p_params[0], p_params[1], p_posAeroport);
            }
            else if (p_type == 1)
            {
                vehicule = new HelicoSecours(p_nom, p_params[0], p_params[1], p_posAeroport);
            }
            else if (p_type == 2)
            {
                vehicule = new AvionPassagers(p_nom, p_params[0], p_params[1], p_params[2], p_params[3], p_posAeroport); 
            }
            else if (p_type == 3)
            {
                vehicule = new AvionMarchandises(p_nom, p_params[0], p_params[1], p_params[2], p_params[3], p_posAeroport);
            }
            else if (p_type == 4)
            {
                vehicule = new AvionCiterne(p_nom, p_params[0], p_params[1], p_params[2], p_params[3], p_posAeroport); 
            }

            return vehicule;
        }

        public Aeroport creerAeroport(string p_nom, int p_minPass, int p_maxPass, int p_minMarch, int p_maxMarch, PosCarte p_pos) //Créer un objet aéroport
        {
            Aeroport aeroport = new Aeroport(p_nom, p_minPass, p_maxPass, p_minMarch, p_maxMarch, p_pos);
            return aeroport;
        }

        public PosCarte creerPos(int p_x, int p_y, int[] p_taille) //Créer un objet pos
        {
            PosCarte pos = new PosCarte(p_x, p_y, p_taille);
            return pos;
        }
    }
}

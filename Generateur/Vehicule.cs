﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Generateur
{
    [XmlInclude(typeof(AvionPassagers))]
    [XmlInclude(typeof(AvionMarchandises))]
    [XmlInclude(typeof(AvionObservateur))]
    [XmlInclude(typeof(AvionCiterne))]
    [XmlInclude(typeof(HelicoSecours))]
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

        public Vehicule()
        {

        }

        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        public int KMH
        {
            get { return m_KMH; }
            set { m_KMH = value; }
        }

        public int Maintenance
        {
            get { return m_tempsMaintenance; }
            set { m_tempsMaintenance = value; }
        }

        public ConsoleColor Couleur
        {
            get { return m_couleur; }
            set { m_couleur = value; }
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

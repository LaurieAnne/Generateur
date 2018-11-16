using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public partial class FormGenerateur : Form
    {
        Generateur m_generateur; //Le générateur
        Scenario m_scenario; //Le scénario

        public FormGenerateur(Generateur p_generateur, Scenario p_scenario) //Constructeur
        {
            InitializeComponent();
            m_generateur = p_generateur;
            m_scenario = p_scenario;
        }
    }
}

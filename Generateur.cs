using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generateur
{
    public class Generateur
    {
        FormGenerateur m_interface; //Interface du générateur
        Scenario m_scenario; //Façade/Médiateur

        [STAThread]

		static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Generateur m_generateur = new Generateur();
        }

        public Generateur() //Constructeur
        {
            m_scenario = new Scenario();
            m_interface = new FormGenerateur(this, m_scenario);
            Application.Run(m_interface);
        }
    }
}

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
        Scenario m_scenario; //Le scénario

        public FormGenerateur(Scenario p_scenario)
        {
            InitializeComponent();
            m_scenario = p_scenario;
        }

        private void FormGenerateur_Load(object sender, EventArgs e)
        {

        }

        private void cmdAjAeroport_MouseHover(object sender, EventArgs e)
        {
            this.cmdAjAeroport.BackColor = Color.SkyBlue;
        }

        private void cmdAjAeroport_MouseLeave(object sender, EventArgs e)
        {
            this.cmdAjAeroport.BackColor = Color.Transparent;
        }

        private void cmdAjAeroport_MouseEnter(object sender, EventArgs e)
        {
            this.cmdAjAeroport.BackColor = Color.SkyBlue;
        }

        private void cmdAjVehicule_MouseHover(object sender, EventArgs e)
        {
            this.cmdAjVehicule.BackColor = Color.SkyBlue;
        }

        private void cmdAjVehicule_MouseLeave(object sender, EventArgs e)
        {
            this.cmdAjVehicule.BackColor = Color.Transparent;
        }

        private void cmdAjVehicule_MouseEnter(object sender, EventArgs e)
        {
            this.cmdAjVehicule.BackColor = Color.SkyBlue;
        }
    }
}

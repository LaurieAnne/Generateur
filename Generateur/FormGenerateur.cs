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

        private void cmdAjAeroport_Click(object sender, EventArgs e)
        {
            string nom = txtAeroNom.Text;
            int minPass = Convert.ToInt32(txtMinPass.Text);
            int maxPass = Convert.ToInt32(txtMaxPass.Text);
            int minMarch = Convert.ToInt32(txtMinMarch.Text);
            int maxMarch = Convert.ToInt32(txtMaxMarch.Text);

            m_scenario.ajouterAeroport(nom, minPass, maxPass, minMarch, maxMarch);
        }

        private void cmdAjVehicule_Click(object sender, EventArgs e)
        {
            int aeroport = lstAeroports.SelectedIndex;

            if (aeroport > -1)
            {
                int index = cmbType.SelectedIndex;
                string nom = txtVehNom.Text;
                int KMH = Convert.ToInt32(txtKMH.Text);
                int tempsMaint = Convert.ToInt32(txtMaint.Text);

                if (index == 0 || index == 1) //Observateur ou secours
                {
                    m_scenario.ajouterVehicule(nom, KMH, tempsMaint, index == 0, aeroport);
                }
                else if (index == 2 || index == 3) //Passagers ou marchandises
                {
                    int tempsCharg = Convert.ToInt32(txtEmbOuCharg.Text);
                    int tempsLarg = Convert.ToInt32(txtDebOuLarg.Text);
                    m_scenario.ajouterVehicule(nom, KMH, tempsMaint, tempsCharg, tempsLarg, index == 2, aeroport);
                }
                else
                {
                    int tempsCharg = Convert.ToInt32(txtEmbOuCharg.Text);
                    int tempsLarg = Convert.ToInt32(txtDebOuLarg.Text);
                    m_scenario.ajouterVehicule(nom, KMH, tempsMaint, tempsCharg, tempsLarg, aeroport);
                }
            }
        }
    }
}

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

        private void FormGenerateur_Load(object sender, EventArgs e) //À l'affichage la fenêtre
        {
            cmbType.Items.Add("Observateur");
            cmbType.Items.Add("Secours");
            cmbType.Items.Add("Passagers");
            cmbType.Items.Add("Marchandises");
            cmbType.Items.Add("Pompier");
            etqEmb.Visible = false;
            etqDeb.Visible = false;
            etqCharg.Visible = false;
            etqLarg.Visible = false;
            txtEmbOuCharg.Visible = false;
            txtDebOuLarg.Visible = false;
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

        private void cmdAjAeroport_Click(object sender, EventArgs e) //Ajouter un aéroport
        {
            if ((txtAeroNom.Text != "") && (txtMinPass.Text != "") && (txtMaxPass.Text != "") && (txtMinMarch.Text != "") && (txtMaxMarch.Text != ""))
            {
                int minPass = Convert.ToInt32(txtMinPass.Text);
                int maxPass = Convert.ToInt32(txtMaxPass.Text);
                int minMarch = Convert.ToInt32(txtMinMarch.Text);
                int maxMarch = Convert.ToInt32(txtMaxMarch.Text);
                m_scenario.ajouterAeroport(txtAeroNom.Text, minPass, maxPass, minMarch, maxMarch);
            }
            else
            {
                MessageBox.Show("Un champ n'a pas été rempli.");
            }
        }

        private void cmdAjVehicule_Click(object sender, EventArgs e) //Ajouter un véhicule à l'aéroport
        {
            if (lstAeroports.SelectedIndex > -1) //Si un aéroport est choisi
            {
                if ((txtVehNom.Text != "") && (txtKMH.Text != "") && (txtMaint.Text != ""))
                {
                    int aeroport = lstAeroports.SelectedIndex;
                    int index = cmbType.SelectedIndex;
                    int KMH = Convert.ToInt32(txtKMH.Text);
                    int tempsMaint = Convert.ToInt32(txtMaint.Text);

                    if (index == 0 || index == 1) //Observateur ou secours
                    {
                        m_scenario.ajouterVehicule(txtVehNom.Text, KMH, tempsMaint, index, aeroport); //Ajouter
                    }
                    else //Passagers, marchandises ou pompier
                    {
                        if ((txtEmbOuCharg.Text != "") && (txtDebOuLarg.Text != ""))
                        {
                            int tempsEmbOuCharg = Convert.ToInt32(txtEmbOuCharg.Text);
                            int tempsDebOuLarg = Convert.ToInt32(txtDebOuLarg.Text);

                            m_scenario.ajouterVehicule(txtVehNom.Text, KMH, tempsMaint, tempsEmbOuCharg, tempsDebOuLarg, index, aeroport); //Ajouter
                        }
                        else
                        {
                            MessageBox.Show("Un champ n'a pas été rempli.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Un champ n'a pas été rempli.");
                }
            }
            else
            {
                MessageBox.Show("Aucun aéroport n'a été choisi.");
            }
        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e) //Cacher ou voir les cases spéciales
        {
            int index = cmbType.SelectedIndex;
            if (index == -1 || index == 0 || index == 1) //Observateur ou secours 
            {
                etqEmb.Visible = false;
                etqDeb.Visible = false;
                etqCharg.Visible = false;
                etqLarg.Visible = false;
                txtEmbOuCharg.Visible = false;
                txtDebOuLarg.Visible = false;
            }
            else if (index == 2 || index == 3) //Passagers ou marchandises
            {
                etqEmb.Visible = true;
                etqDeb.Visible = true;
                etqCharg.Visible = false;
                etqLarg.Visible = false;
                txtEmbOuCharg.Visible = true;
                txtDebOuLarg.Visible = true;
            }
            else //Pompier
            {
                etqEmb.Visible = false;
                etqDeb.Visible = false;
                etqCharg.Visible = true;
                etqLarg.Visible = true;
                txtEmbOuCharg.Visible = true;
                txtDebOuLarg.Visible = true;
            }
        }
    }
}

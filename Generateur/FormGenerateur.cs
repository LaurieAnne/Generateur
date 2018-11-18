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
        private Scenario m_scenario; //Le scénario

        public FormGenerateur(Scenario p_scenario) //Constructeur
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
            cmbTypeMod.Items.Add("Observateur");
            cmbTypeMod.Items.Add("Secours");
            cmbTypeMod.Items.Add("Passagers");
            cmbTypeMod.Items.Add("Marchandises");
            cmbTypeMod.Items.Add("Pompier");
            etqEmb.Visible = false;
            etqDeb.Visible = false;
            etqCharg.Visible = false;
            etqLarg.Visible = false;
            txtEmbOuCharg.Visible = false;
            txtDebOuLarg.Visible = false;
            etqEmbMod.Visible = false;
            etqDebMod.Visible = false;
            etqChargMod.Visible = false;
            etqLargMod.Visible = false;
            txtEmbOuChargMod.Visible = false;
            txtDebOuLargMod.Visible = false;
        }

        private void cmdAjAeroport_MouseHover(object sender, EventArgs e)
        {
            this.cmdAjAeroport.BackColor = Color.SkyBlue;
        }

        private void cmdAjAeroport_MouseLeave(object sender, EventArgs e)
        {
            this.cmdAjAeroport.BackColor = Color.Snow;
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
            this.cmdAjVehicule.BackColor = Color.Snow;
        }

        private void cmdAjVehicule_MouseEnter(object sender, EventArgs e)
        {
            this.cmdAjVehicule.BackColor = Color.SkyBlue;
        }

        private void afficherAeroports() //Afficher les aéroports
        {
            string[] aeroports = m_scenario.obtenirAeroports(); //Tableau des aéroports

            lstAeroports.Items.Clear();
            lstVehicules.Items.Clear();

            for (int i = 0; i < aeroports.Length; i++)
            {
                lstAeroports.Items.Add(aeroports[i]);
            }
        }

        private void afficherVehicules() //Afficher les véhicules
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi
            string[] vehicules = m_scenario.obtenirVehicules(aeroport); //Tableau des véhicules

            lstVehicules.Items.Clear();

            for (int i = 0; i < vehicules.Length; i++)
            {
                lstVehicules.Items.Add(vehicules[i]);
            }
        }

        private void cmdAjAeroport_Click(object sender, EventArgs e) //Ajouter un aéroport
        {
            if ((txtAeroNom.Text != "") && (txtMinPass.Text != "") && (txtMaxPass.Text != "") && (txtMinMarch.Text != "") && (txtMaxMarch.Text != ""))
            {
                int minPass = Convert.ToInt32(txtMinPass.Text);
                int maxPass = Convert.ToInt32(txtMaxPass.Text);
                int minMarch = Convert.ToInt32(txtMinMarch.Text);
                int maxMarch = Convert.ToInt32(txtMaxMarch.Text);

                if ((maxPass > minPass) && (maxMarch > minMarch))
                {
                    m_scenario.ajouterAeroport(txtAeroNom.Text, minPass, maxPass, minMarch, maxMarch); //Ajouter
                    afficherAeroports();
                }
                else
                {
                    MessageBox.Show("Le minimum ne peut être plus grand que le maximum.");
                }
            }
            else
            {
                MessageBox.Show("Un champ n'a pas été rempli.");
            }
        }

        private void cmdAjVehicule_Click(object sender, EventArgs e) //Ajouter un véhicule à l'aéroport
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi

            if (aeroport > -1)
            {
                int index = cmbType.SelectedIndex; //Type choisi

                if ((index > -1) && (txtVehNom.Text != "") && (txtKMH.Text != "") && (txtMaint.Text != "") 
                    && ((txtEmbOuCharg.Text != "") || !txtEmbOuCharg.Visible) && ((txtDebOuLarg.Text != "") || !txtDebOuLarg.Visible))
                {
                    int[] arrayParams = new int[2]; //Les paramètres
                    if (txtEmbOuCharg.Visible && txtDebOuLarg.Visible)
                    {
                        arrayParams = new int[4];
                        arrayParams[2] = Convert.ToInt32(txtEmbOuCharg.Text);
                        arrayParams[3] = Convert.ToInt32(txtDebOuLarg.Text);
                    }
                    arrayParams[0] = Convert.ToInt32(txtKMH.Text);
                    arrayParams[1] = Convert.ToInt32(txtMaint.Text);

                    m_scenario.ajouterVehicule(txtVehNom.Text, arrayParams, index, aeroport); //Ajouter
                    afficherVehicules();
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
            int index = cmbType.SelectedIndex; //Type choisi

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

        private void afficherInfosAeroport() //Afficher les infos de l'aéroport choisi
        {
            string texte = lstAeroports.Text; //Ligne de texte
            string[] infos = texte.Split(','); //Infos

            txtAeroNomMod.Text = infos[0];
            txtMinPassMod.Text = infos[1].Substring(infos[1].IndexOf(":") + 2);
            txtMaxPassMod.Text = infos[2].Substring(infos[2].IndexOf(":") + 2);
            txtMinMarchMod.Text = infos[3].Substring(infos[3].IndexOf(":") + 2);
            txtMaxMarchMod.Text = infos[4].Substring(infos[4].IndexOf(":") + 2);
        }

        private void lstAeroports_SelectedValueChanged(object sender, EventArgs e) //Sur un changement d'aéroport
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi

            if (aeroport > -1)
            {
                afficherVehicules();
                afficherInfosAeroport();
            }
            else
            {
                lstVehicules.Items.Clear();
            }
        }

        private void txtMinPass_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaxPass_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMinMarch_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKMH_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaint_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEmbOuCharg_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDebOuLarg_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaxMarch_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmdGenerer_MouseEnter(object sender, EventArgs e)
        {
            this.cmdGenerer.BackColor = Color.DodgerBlue;
        }

        private void cmdGenerer_MouseHover(object sender, EventArgs e)
        {
            this.cmdGenerer.BackColor = Color.DodgerBlue;
        }

        private void cmdGenerer_MouseLeave(object sender, EventArgs e)
        {
            this.cmdGenerer.BackColor = Color.Snow;
        }

        private void cmdSuppAeroport_Click(object sender, EventArgs e) //Supprimer un aéroport
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi

            if (aeroport > -1)
            {
                m_scenario.supprimerAeroport(aeroport);
                afficherAeroports();
            }
            else
            {
                MessageBox.Show("Aucun aéroport n'a été choisi.");
            }
        }

        private void cmdSuppVehicule_Click(object sender, EventArgs e) //Supprimer un véhicule
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi

            if (aeroport > -1)
            {
                int vehicule = lstVehicules.SelectedIndex; //Véhicule choisi

                if (vehicule > -1)
                {
                    m_scenario.supprimerVehicule(aeroport, vehicule);
                    afficherVehicules();
                }
                else
                {
                    MessageBox.Show("Aucun véhicule n'a été choisi.");
                }
            }
            else
            {
                MessageBox.Show("Aucun véhicule n'a été choisi.");
            }
        }

        private void cmbTypeMod_SelectedIndexChanged(object sender, EventArgs e) //Cacher ou voir les cases spéciales
        {
            int index = cmbTypeMod.SelectedIndex; //Type choisi

            if (index == -1 || index == 0 || index == 1) //Observateur ou secours 
            {
                etqEmbMod.Visible = false;
                etqDebMod.Visible = false;
                etqChargMod.Visible = false;
                etqLargMod.Visible = false;
                txtEmbOuChargMod.Visible = false;
                txtDebOuLargMod.Visible = false;
            }
            else if (index == 2 || index == 3) //Passagers ou marchandises
            {
                etqEmbMod.Visible = true;
                etqDebMod.Visible = true;
                etqChargMod.Visible = false;
                etqLargMod.Visible = false;
                txtEmbOuChargMod.Visible = true;
                txtDebOuLargMod.Visible = true;
            }
            else //Pompier
            {
                etqEmbMod.Visible = false;
                etqDebMod.Visible = false;
                etqChargMod.Visible = true;
                etqLargMod.Visible = true;
                txtEmbOuChargMod.Visible = true;
                txtDebOuLargMod.Visible = true;
            }
        }

        private void afficherInfosVehicule() //Afficher les infos du véhicule choisi
        {
            string texte = lstVehicules.Text; //Ligne de texte
            string[] infos = texte.Split(','); //Infos

            string[] nomType = infos[0].Split('(');
            txtVehNomMod.Text = nomType[0].Substring(0, nomType[0].Length - 1); 
            cmbTypeMod.SelectedItem = nomType[1].Substring(0, nomType[1].Length - 1);
            txtKMHMod.Text = infos[1].Substring(infos[1].IndexOf(":") + 2);
            txtMaintMod.Text = infos[2].Substring(infos[2].IndexOf(":") + 2);
            if (txtEmbOuChargMod.Visible && txtDebOuLargMod.Visible) //Si cases spéciales
            {
                txtEmbOuChargMod.Text = infos[3].Substring(infos[3].IndexOf(":") + 2);
                txtDebOuLargMod.Text = infos[4].Substring(infos[4].IndexOf(":") + 2);
            }
        }

        private void lstVehicules_SelectedValueChanged(object sender, EventArgs e) //Sur un changement de véhicule
        {
            int vehicule = lstVehicules.SelectedIndex; //Véhicule choisi

            if (vehicule > -1)
            {
                afficherInfosVehicule();
            }
        }

        private void txtAeroNomMod_KeyPress(object sender, KeyPressEventArgs e) //Ne pas permettre les symboles
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' ');
        }

        private void txtAeroNom_KeyPress(object sender, KeyPressEventArgs e) //Ne pas permettre les symboles
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' ');
        }

        private void txtVehNom_KeyPress(object sender, KeyPressEventArgs e) //Ne pas permettre les symboles
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' ');
        }

        private void txtVehNomMod_KeyPress(object sender, KeyPressEventArgs e) //Ne pas permettre les symboles
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' ');
        }

        private void cmdModAeroport_MouseEnter(object sender, EventArgs e)
        {
            this.cmdModAeroport.BackColor = Color.SkyBlue;
        }

        private void cmdModAeroport_MouseHover(object sender, EventArgs e)
        {
            this.cmdModAeroport.BackColor = Color.SkyBlue;
        }

        private void cmdModAeroport_MouseLeave(object sender, EventArgs e)
        {
            this.cmdModAeroport.BackColor = Color.Snow;
        }

        private void cmdModVehicule_MouseEnter(object sender, EventArgs e)
        {
            this.cmdModVehicule.BackColor = Color.SkyBlue;
        }

        private void cmdModVehicule_MouseHover(object sender, EventArgs e)
        {
            this.cmdModVehicule.BackColor = Color.SkyBlue;
        }

        private void cmdModVehicule_MouseLeave(object sender, EventArgs e)
        {
            this.cmdModVehicule.BackColor = Color.Snow;
        }

        private void txtMinPassMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaxPassMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMinMarchMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaxMarchMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKMHMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaintMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEmbOuChargMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDebOuLargMod_KeyPress(object sender, KeyPressEventArgs e) //Accepter seulement les chiffres
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmdModAeroport_Click(object sender, EventArgs e) //Modifier un aéroport
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi

            if (aeroport > -1)
            {
                if ((txtAeroNomMod.Text != "") && (txtMinPassMod.Text != "") && (txtMaxPassMod.Text != "") && (txtMinMarchMod.Text != "") && (txtMaxMarchMod.Text != ""))
                {
                    int minPass = Convert.ToInt32(txtMinPassMod.Text);
                    int maxPass = Convert.ToInt32(txtMaxPassMod.Text);
                    int minMarch = Convert.ToInt32(txtMinMarchMod.Text);
                    int maxMarch = Convert.ToInt32(txtMaxMarchMod.Text);

                    if ((maxPass > minPass) && (maxMarch > minMarch))
                    {
                        m_scenario.modifierAeroport(txtAeroNomMod.Text, minPass, maxPass, minMarch, maxMarch, aeroport); //Modifier
                        afficherAeroports();
                        lstAeroports.SelectedIndex = aeroport;
                    }
                    else
                    {
                        MessageBox.Show("Le minimum ne peut être plus grand que le maximum.");
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

        private void cmdModVehicule_Click(object sender, EventArgs e) //Modifier un véhicule
        {
            int aeroport = lstAeroports.SelectedIndex; //Aéroport choisi

            if (aeroport > -1)
            {
                int vehicule = lstVehicules.SelectedIndex; //Véhicule choisi

                if (vehicule > -1)
                {
                    int index = cmbTypeMod.SelectedIndex; //Type choisi

                    if ((index > -1) && (txtVehNomMod.Text != "") && (txtKMHMod.Text != "") && (txtMaintMod.Text != "")
                        && ((txtEmbOuChargMod.Text != "") || !txtEmbOuChargMod.Visible) && ((txtDebOuLargMod.Text != "") || !txtDebOuLargMod.Visible))
                    {
                        int[] arrayParams = new int[2]; //Les paramètres
                        if (txtEmbOuChargMod.Visible && txtDebOuLargMod.Visible)
                        {
                            arrayParams = new int[4];
                            arrayParams[2] = Convert.ToInt32(txtEmbOuChargMod.Text);
                            arrayParams[3] = Convert.ToInt32(txtDebOuLargMod.Text);
                        }
                        arrayParams[0] = Convert.ToInt32(txtKMHMod.Text);
                        arrayParams[1] = Convert.ToInt32(txtMaintMod.Text);

                        m_scenario.modifierVehicule(txtVehNomMod.Text, arrayParams, vehicule, aeroport); //Modifier
                        afficherVehicules();
                        lstVehicules.SelectedIndex = vehicule;
                    }
                    else
                    {
                        MessageBox.Show("Un champ n'a pas été rempli.");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun véhicule n'a été choisi.");
                }
            }
            else
            {
                MessageBox.Show("Aucun véhicule n'a été choisi.");
            }
        }
    }
}

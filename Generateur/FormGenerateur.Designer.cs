namespace Generateur
{
    partial class FormGenerateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAeroNom = new System.Windows.Forms.TextBox();
            this.txtMinMarch = new System.Windows.Forms.TextBox();
            this.txtMaxPass = new System.Windows.Forms.TextBox();
            this.txtMinPass = new System.Windows.Forms.TextBox();
            this.cmdAjAeroport = new System.Windows.Forms.Button();
            this.txtMaxMarch = new System.Windows.Forms.TextBox();
            this.etqAeroNom = new System.Windows.Forms.Label();
            this.etqMinPass = new System.Windows.Forms.Label();
            this.etqMaxPass = new System.Windows.Forms.Label();
            this.etqMinMarch = new System.Windows.Forms.Label();
            this.etqMaxMarch = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.etqPos = new System.Windows.Forms.Label();
            this.etqMaint = new System.Windows.Forms.Label();
            this.txtMaint = new System.Windows.Forms.TextBox();
            this.etqDeb = new System.Windows.Forms.Label();
            this.etqEmb = new System.Windows.Forms.Label();
            this.etqKMH = new System.Windows.Forms.Label();
            this.etqType = new System.Windows.Forms.Label();
            this.etqVehNom = new System.Windows.Forms.Label();
            this.txtDebOuLarg = new System.Windows.Forms.TextBox();
            this.cmdAjVehicule = new System.Windows.Forms.Button();
            this.txtEmbOuCharg = new System.Windows.Forms.TextBox();
            this.txtVehNom = new System.Windows.Forms.TextBox();
            this.txtKMH = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tabGenerateur = new System.Windows.Forms.TabControl();
            this.ongAj = new System.Windows.Forms.TabPage();
            this.cmdCarte = new System.Windows.Forms.Button();
            this.etqCharg = new System.Windows.Forms.Label();
            this.etqLarg = new System.Windows.Forms.Label();
            this.ongMod = new System.Windows.Forms.TabPage();
            this.txtAeroNomMod = new System.Windows.Forms.TextBox();
            this.txtMinMarchMod = new System.Windows.Forms.TextBox();
            this.cmbTypeMod = new System.Windows.Forms.ComboBox();
            this.txtMaxPassMod = new System.Windows.Forms.TextBox();
            this.txtKMHMod = new System.Windows.Forms.TextBox();
            this.txtMinPassMod = new System.Windows.Forms.TextBox();
            this.etqMaintMod = new System.Windows.Forms.Label();
            this.cmdModAeroport = new System.Windows.Forms.Button();
            this.txtMaintMod = new System.Windows.Forms.TextBox();
            this.txtMaxMarchMod = new System.Windows.Forms.TextBox();
            this.etqDebMod = new System.Windows.Forms.Label();
            this.etqAeroNomMod = new System.Windows.Forms.Label();
            this.etqEmbMod = new System.Windows.Forms.Label();
            this.etqMinPassMod = new System.Windows.Forms.Label();
            this.etqKMHMod = new System.Windows.Forms.Label();
            this.etqMaxPassMod = new System.Windows.Forms.Label();
            this.etqTypeMod = new System.Windows.Forms.Label();
            this.etqMinMarchMod = new System.Windows.Forms.Label();
            this.etqVehNomMod = new System.Windows.Forms.Label();
            this.etqMaxMarchMod = new System.Windows.Forms.Label();
            this.txtDebOuLargMod = new System.Windows.Forms.TextBox();
            this.txtPosMod = new System.Windows.Forms.TextBox();
            this.cmdModVehicule = new System.Windows.Forms.Button();
            this.etqPosMod = new System.Windows.Forms.Label();
            this.txtEmbOuChargMod = new System.Windows.Forms.TextBox();
            this.txtVehNomMod = new System.Windows.Forms.TextBox();
            this.etqChargMod = new System.Windows.Forms.Label();
            this.etqLargMod = new System.Windows.Forms.Label();
            this.cmdCarteMod = new System.Windows.Forms.Button();
            this.lstAeroports = new System.Windows.Forms.ListBox();
            this.lstVehicules = new System.Windows.Forms.ListBox();
            this.cmdSuppAeroport = new System.Windows.Forms.Button();
            this.cmdSuppVehicule = new System.Windows.Forms.Button();
            this.cmdGenerer = new System.Windows.Forms.Button();
            this.txtGenerer = new System.Windows.Forms.TextBox();
            this.tabGenerateur.SuspendLayout();
            this.ongAj.SuspendLayout();
            this.ongMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAeroNom
            // 
            this.txtAeroNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAeroNom.Location = new System.Drawing.Point(165, 6);
            this.txtAeroNom.MaxLength = 100;
            this.txtAeroNom.Name = "txtAeroNom";
            this.txtAeroNom.Size = new System.Drawing.Size(219, 19);
            this.txtAeroNom.TabIndex = 1;
            this.txtAeroNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAeroNom_KeyPress);
            // 
            // txtMinMarch
            // 
            this.txtMinMarch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinMarch.Location = new System.Drawing.Point(165, 81);
            this.txtMinMarch.MaxLength = 9;
            this.txtMinMarch.Name = "txtMinMarch";
            this.txtMinMarch.Size = new System.Drawing.Size(219, 19);
            this.txtMinMarch.TabIndex = 4;
            this.txtMinMarch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinMarch_KeyPress);
            // 
            // txtMaxPass
            // 
            this.txtMaxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxPass.Location = new System.Drawing.Point(165, 56);
            this.txtMaxPass.MaxLength = 9;
            this.txtMaxPass.Name = "txtMaxPass";
            this.txtMaxPass.Size = new System.Drawing.Size(219, 19);
            this.txtMaxPass.TabIndex = 3;
            this.txtMaxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxPass_KeyPress);
            // 
            // txtMinPass
            // 
            this.txtMinPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinPass.Location = new System.Drawing.Point(165, 31);
            this.txtMinPass.MaxLength = 9;
            this.txtMinPass.Name = "txtMinPass";
            this.txtMinPass.Size = new System.Drawing.Size(219, 19);
            this.txtMinPass.TabIndex = 2;
            this.txtMinPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinPass_KeyPress);
            // 
            // cmdAjAeroport
            // 
            this.cmdAjAeroport.BackColor = System.Drawing.Color.Snow;
            this.cmdAjAeroport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjAeroport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjAeroport.Location = new System.Drawing.Point(165, 156);
            this.cmdAjAeroport.Name = "cmdAjAeroport";
            this.cmdAjAeroport.Size = new System.Drawing.Size(219, 31);
            this.cmdAjAeroport.TabIndex = 7;
            this.cmdAjAeroport.Text = "Ajouter un aéroport";
            this.cmdAjAeroport.UseVisualStyleBackColor = false;
            this.cmdAjAeroport.Click += new System.EventHandler(this.cmdAjAeroport_Click);
            this.cmdAjAeroport.MouseEnter += new System.EventHandler(this.cmdAjAeroport_MouseEnter);
            this.cmdAjAeroport.MouseLeave += new System.EventHandler(this.cmdAjAeroport_MouseLeave);
            this.cmdAjAeroport.MouseHover += new System.EventHandler(this.cmdAjAeroport_MouseHover);
            // 
            // txtMaxMarch
            // 
            this.txtMaxMarch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxMarch.Location = new System.Drawing.Point(165, 106);
            this.txtMaxMarch.MaxLength = 9;
            this.txtMaxMarch.Name = "txtMaxMarch";
            this.txtMaxMarch.Size = new System.Drawing.Size(219, 19);
            this.txtMaxMarch.TabIndex = 5;
            this.txtMaxMarch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxMarch_KeyPress);
            // 
            // etqAeroNom
            // 
            this.etqAeroNom.AutoSize = true;
            this.etqAeroNom.Location = new System.Drawing.Point(125, 8);
            this.etqAeroNom.Name = "etqAeroNom";
            this.etqAeroNom.Size = new System.Drawing.Size(34, 14);
            this.etqAeroNom.TabIndex = 9;
            this.etqAeroNom.Text = "Nom :";
            this.etqAeroNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinPass
            // 
            this.etqMinPass.AutoSize = true;
            this.etqMinPass.Location = new System.Drawing.Point(51, 33);
            this.etqMinPass.Name = "etqMinPass";
            this.etqMinPass.Size = new System.Drawing.Size(108, 14);
            this.etqMinPass.TabIndex = 10;
            this.etqMinPass.Text = "Minimum Passagers :";
            this.etqMinPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxPass
            // 
            this.etqMaxPass.AutoSize = true;
            this.etqMaxPass.Location = new System.Drawing.Point(47, 58);
            this.etqMaxPass.Name = "etqMaxPass";
            this.etqMaxPass.Size = new System.Drawing.Size(112, 14);
            this.etqMaxPass.TabIndex = 11;
            this.etqMaxPass.Text = "Maximum Passagers :";
            this.etqMaxPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinMarch
            // 
            this.etqMinMarch.AutoSize = true;
            this.etqMinMarch.Location = new System.Drawing.Point(35, 83);
            this.etqMinMarch.Name = "etqMinMarch";
            this.etqMinMarch.Size = new System.Drawing.Size(124, 14);
            this.etqMinMarch.TabIndex = 12;
            this.etqMinMarch.Text = "Minimum Marchandises :";
            this.etqMinMarch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxMarch
            // 
            this.etqMaxMarch.AutoSize = true;
            this.etqMaxMarch.Location = new System.Drawing.Point(31, 108);
            this.etqMaxMarch.Name = "etqMaxMarch";
            this.etqMaxMarch.Size = new System.Drawing.Size(128, 14);
            this.etqMaxMarch.TabIndex = 13;
            this.etqMaxMarch.Text = "Maximum Marchandises :";
            this.etqMaxMarch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPos
            // 
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPos.Enabled = false;
            this.txtPos.Location = new System.Drawing.Point(165, 131);
            this.txtPos.Name = "txtPos";
            this.txtPos.ReadOnly = true;
            this.txtPos.Size = new System.Drawing.Size(219, 19);
            this.txtPos.TabIndex = 14;
            // 
            // etqPos
            // 
            this.etqPos.AutoSize = true;
            this.etqPos.Location = new System.Drawing.Point(25, 133);
            this.etqPos.Name = "etqPos";
            this.etqPos.Size = new System.Drawing.Size(134, 14);
            this.etqPos.TabIndex = 15;
            this.etqPos.Text = "Emplacement sur la carte :";
            this.etqPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaint
            // 
            this.etqMaint.AutoSize = true;
            this.etqMaint.Location = new System.Drawing.Point(3, 290);
            this.etqMaint.Name = "etqMaint";
            this.etqMaint.Size = new System.Drawing.Size(156, 14);
            this.etqMaint.TabIndex = 31;
            this.etqMaint.Text = "Temps de maintenance (mins) :";
            this.etqMaint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaint
            // 
            this.txtMaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaint.Location = new System.Drawing.Point(165, 289);
            this.txtMaint.MaxLength = 9;
            this.txtMaint.Name = "txtMaint";
            this.txtMaint.Size = new System.Drawing.Size(219, 19);
            this.txtMaint.TabIndex = 12;
            this.txtMaint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaint_KeyPress);
            // 
            // etqDeb
            // 
            this.etqDeb.AutoSize = true;
            this.etqDeb.Location = new System.Drawing.Point(10, 340);
            this.etqDeb.Name = "etqDeb";
            this.etqDeb.Size = new System.Drawing.Size(149, 14);
            this.etqDeb.TabIndex = 29;
            this.etqDeb.Text = "Temps débarquement (mins) :";
            this.etqDeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqEmb
            // 
            this.etqEmb.AutoSize = true;
            this.etqEmb.Location = new System.Drawing.Point(8, 315);
            this.etqEmb.Name = "etqEmb";
            this.etqEmb.Size = new System.Drawing.Size(151, 14);
            this.etqEmb.TabIndex = 28;
            this.etqEmb.Text = "Temps embarquement (mins) :";
            this.etqEmb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqKMH
            // 
            this.etqKMH.AutoSize = true;
            this.etqKMH.Location = new System.Drawing.Point(80, 265);
            this.etqKMH.Name = "etqKMH";
            this.etqKMH.Size = new System.Drawing.Size(79, 14);
            this.etqKMH.TabIndex = 27;
            this.etqKMH.Text = "KM/H (1 à 10) :";
            this.etqKMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqType
            // 
            this.etqType.AutoSize = true;
            this.etqType.Location = new System.Drawing.Point(123, 239);
            this.etqType.Name = "etqType";
            this.etqType.Size = new System.Drawing.Size(36, 14);
            this.etqType.TabIndex = 26;
            this.etqType.Text = "Type :";
            this.etqType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqVehNom
            // 
            this.etqVehNom.AutoSize = true;
            this.etqVehNom.Location = new System.Drawing.Point(125, 214);
            this.etqVehNom.Name = "etqVehNom";
            this.etqVehNom.Size = new System.Drawing.Size(34, 14);
            this.etqVehNom.TabIndex = 25;
            this.etqVehNom.Text = "Nom :";
            this.etqVehNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDebOuLarg
            // 
            this.txtDebOuLarg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebOuLarg.Location = new System.Drawing.Point(165, 339);
            this.txtDebOuLarg.MaxLength = 9;
            this.txtDebOuLarg.Name = "txtDebOuLarg";
            this.txtDebOuLarg.Size = new System.Drawing.Size(219, 19);
            this.txtDebOuLarg.TabIndex = 14;
            this.txtDebOuLarg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebOuLarg_KeyPress);
            // 
            // cmdAjVehicule
            // 
            this.cmdAjVehicule.BackColor = System.Drawing.Color.Snow;
            this.cmdAjVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjVehicule.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjVehicule.Location = new System.Drawing.Point(165, 364);
            this.cmdAjVehicule.Name = "cmdAjVehicule";
            this.cmdAjVehicule.Size = new System.Drawing.Size(219, 31);
            this.cmdAjVehicule.TabIndex = 15;
            this.cmdAjVehicule.Text = "Ajouter un véhicule";
            this.cmdAjVehicule.UseVisualStyleBackColor = false;
            this.cmdAjVehicule.Click += new System.EventHandler(this.cmdAjVehicule_Click);
            this.cmdAjVehicule.MouseEnter += new System.EventHandler(this.cmdAjVehicule_MouseEnter);
            this.cmdAjVehicule.MouseLeave += new System.EventHandler(this.cmdAjVehicule_MouseLeave);
            this.cmdAjVehicule.MouseHover += new System.EventHandler(this.cmdAjVehicule_MouseHover);
            // 
            // txtEmbOuCharg
            // 
            this.txtEmbOuCharg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmbOuCharg.Location = new System.Drawing.Point(165, 314);
            this.txtEmbOuCharg.MaxLength = 9;
            this.txtEmbOuCharg.Name = "txtEmbOuCharg";
            this.txtEmbOuCharg.Size = new System.Drawing.Size(219, 19);
            this.txtEmbOuCharg.TabIndex = 13;
            this.txtEmbOuCharg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmbOuCharg_KeyPress);
            // 
            // txtVehNom
            // 
            this.txtVehNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehNom.Location = new System.Drawing.Point(165, 212);
            this.txtVehNom.MaxLength = 100;
            this.txtVehNom.Name = "txtVehNom";
            this.txtVehNom.Size = new System.Drawing.Size(219, 19);
            this.txtVehNom.TabIndex = 9;
            this.txtVehNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVehNom_KeyPress);
            // 
            // txtKMH
            // 
            this.txtKMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKMH.Location = new System.Drawing.Point(165, 264);
            this.txtKMH.MaxLength = 9;
            this.txtKMH.Name = "txtKMH";
            this.txtKMH.Size = new System.Drawing.Size(219, 19);
            this.txtKMH.TabIndex = 11;
            this.txtKMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKMH_KeyPress);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(165, 237);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(219, 21);
            this.cmbType.TabIndex = 10;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // tabGenerateur
            // 
            this.tabGenerateur.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabGenerateur.Controls.Add(this.ongAj);
            this.tabGenerateur.Controls.Add(this.ongMod);
            this.tabGenerateur.Location = new System.Drawing.Point(22, 12);
            this.tabGenerateur.Name = "tabGenerateur";
            this.tabGenerateur.SelectedIndex = 0;
            this.tabGenerateur.Size = new System.Drawing.Size(451, 442);
            this.tabGenerateur.TabIndex = 0;
            // 
            // ongAj
            // 
            this.ongAj.BackColor = System.Drawing.Color.LightCyan;
            this.ongAj.Controls.Add(this.txtAeroNom);
            this.ongAj.Controls.Add(this.cmdCarte);
            this.ongAj.Controls.Add(this.txtMinMarch);
            this.ongAj.Controls.Add(this.cmbType);
            this.ongAj.Controls.Add(this.txtMaxPass);
            this.ongAj.Controls.Add(this.txtKMH);
            this.ongAj.Controls.Add(this.txtMinPass);
            this.ongAj.Controls.Add(this.etqMaint);
            this.ongAj.Controls.Add(this.cmdAjAeroport);
            this.ongAj.Controls.Add(this.txtMaint);
            this.ongAj.Controls.Add(this.txtMaxMarch);
            this.ongAj.Controls.Add(this.etqDeb);
            this.ongAj.Controls.Add(this.etqAeroNom);
            this.ongAj.Controls.Add(this.etqEmb);
            this.ongAj.Controls.Add(this.etqMinPass);
            this.ongAj.Controls.Add(this.etqKMH);
            this.ongAj.Controls.Add(this.etqMaxPass);
            this.ongAj.Controls.Add(this.etqType);
            this.ongAj.Controls.Add(this.etqMinMarch);
            this.ongAj.Controls.Add(this.etqVehNom);
            this.ongAj.Controls.Add(this.etqMaxMarch);
            this.ongAj.Controls.Add(this.txtDebOuLarg);
            this.ongAj.Controls.Add(this.txtPos);
            this.ongAj.Controls.Add(this.cmdAjVehicule);
            this.ongAj.Controls.Add(this.etqPos);
            this.ongAj.Controls.Add(this.txtEmbOuCharg);
            this.ongAj.Controls.Add(this.txtVehNom);
            this.ongAj.Controls.Add(this.etqCharg);
            this.ongAj.Controls.Add(this.etqLarg);
            this.ongAj.Location = new System.Drawing.Point(4, 25);
            this.ongAj.Name = "ongAj";
            this.ongAj.Padding = new System.Windows.Forms.Padding(3);
            this.ongAj.Size = new System.Drawing.Size(443, 413);
            this.ongAj.TabIndex = 0;
            this.ongAj.Text = "AJOUTER";
            // 
            // cmdCarte
            // 
            this.cmdCarte.BackgroundImage = global::Generateur.Properties.Resources.pin;
            this.cmdCarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCarte.Location = new System.Drawing.Point(390, 120);
            this.cmdCarte.Name = "cmdCarte";
            this.cmdCarte.Size = new System.Drawing.Size(40, 40);
            this.cmdCarte.TabIndex = 6;
            this.cmdCarte.UseVisualStyleBackColor = true;
            this.cmdCarte.Click += new System.EventHandler(this.cmdCarte_Click);
            // 
            // etqCharg
            // 
            this.etqCharg.AutoSize = true;
            this.etqCharg.Location = new System.Drawing.Point(7, 315);
            this.etqCharg.Name = "etqCharg";
            this.etqCharg.Size = new System.Drawing.Size(152, 14);
            this.etqCharg.TabIndex = 34;
            this.etqCharg.Text = "Temps de chargement (mins) :";
            this.etqCharg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqLarg
            // 
            this.etqLarg.AutoSize = true;
            this.etqLarg.Location = new System.Drawing.Point(28, 340);
            this.etqLarg.Name = "etqLarg";
            this.etqLarg.Size = new System.Drawing.Size(131, 14);
            this.etqLarg.TabIndex = 35;
            this.etqLarg.Text = "Temps de largage (mins) :";
            this.etqLarg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ongMod
            // 
            this.ongMod.BackColor = System.Drawing.Color.LightCyan;
            this.ongMod.Controls.Add(this.txtAeroNomMod);
            this.ongMod.Controls.Add(this.txtMinMarchMod);
            this.ongMod.Controls.Add(this.cmbTypeMod);
            this.ongMod.Controls.Add(this.txtMaxPassMod);
            this.ongMod.Controls.Add(this.txtKMHMod);
            this.ongMod.Controls.Add(this.txtMinPassMod);
            this.ongMod.Controls.Add(this.etqMaintMod);
            this.ongMod.Controls.Add(this.cmdModAeroport);
            this.ongMod.Controls.Add(this.txtMaintMod);
            this.ongMod.Controls.Add(this.txtMaxMarchMod);
            this.ongMod.Controls.Add(this.etqDebMod);
            this.ongMod.Controls.Add(this.etqAeroNomMod);
            this.ongMod.Controls.Add(this.etqEmbMod);
            this.ongMod.Controls.Add(this.etqMinPassMod);
            this.ongMod.Controls.Add(this.etqKMHMod);
            this.ongMod.Controls.Add(this.etqMaxPassMod);
            this.ongMod.Controls.Add(this.etqTypeMod);
            this.ongMod.Controls.Add(this.etqMinMarchMod);
            this.ongMod.Controls.Add(this.etqVehNomMod);
            this.ongMod.Controls.Add(this.etqMaxMarchMod);
            this.ongMod.Controls.Add(this.txtDebOuLargMod);
            this.ongMod.Controls.Add(this.txtPosMod);
            this.ongMod.Controls.Add(this.cmdModVehicule);
            this.ongMod.Controls.Add(this.etqPosMod);
            this.ongMod.Controls.Add(this.txtEmbOuChargMod);
            this.ongMod.Controls.Add(this.txtVehNomMod);
            this.ongMod.Controls.Add(this.etqChargMod);
            this.ongMod.Controls.Add(this.etqLargMod);
            this.ongMod.Controls.Add(this.cmdCarteMod);
            this.ongMod.Location = new System.Drawing.Point(4, 25);
            this.ongMod.Name = "ongMod";
            this.ongMod.Padding = new System.Windows.Forms.Padding(3);
            this.ongMod.Size = new System.Drawing.Size(443, 413);
            this.ongMod.TabIndex = 1;
            this.ongMod.Text = "MODIFIER";
            // 
            // txtAeroNomMod
            // 
            this.txtAeroNomMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAeroNomMod.Location = new System.Drawing.Point(165, 6);
            this.txtAeroNomMod.MaxLength = 100;
            this.txtAeroNomMod.Name = "txtAeroNomMod";
            this.txtAeroNomMod.Size = new System.Drawing.Size(219, 19);
            this.txtAeroNomMod.TabIndex = 36;
            this.txtAeroNomMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAeroNomMod_KeyPress);
            // 
            // txtMinMarchMod
            // 
            this.txtMinMarchMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinMarchMod.Location = new System.Drawing.Point(165, 81);
            this.txtMinMarchMod.MaxLength = 9;
            this.txtMinMarchMod.Name = "txtMinMarchMod";
            this.txtMinMarchMod.Size = new System.Drawing.Size(219, 19);
            this.txtMinMarchMod.TabIndex = 39;
            this.txtMinMarchMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinMarchMod_KeyPress);
            // 
            // cmbTypeMod
            // 
            this.cmbTypeMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeMod.Enabled = false;
            this.cmbTypeMod.FormattingEnabled = true;
            this.cmbTypeMod.Location = new System.Drawing.Point(165, 237);
            this.cmbTypeMod.Name = "cmbTypeMod";
            this.cmbTypeMod.Size = new System.Drawing.Size(219, 21);
            this.cmbTypeMod.TabIndex = 46;
            this.cmbTypeMod.SelectedIndexChanged += new System.EventHandler(this.cmbTypeMod_SelectedIndexChanged);
            // 
            // txtMaxPassMod
            // 
            this.txtMaxPassMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxPassMod.Location = new System.Drawing.Point(165, 56);
            this.txtMaxPassMod.MaxLength = 9;
            this.txtMaxPassMod.Name = "txtMaxPassMod";
            this.txtMaxPassMod.Size = new System.Drawing.Size(219, 19);
            this.txtMaxPassMod.TabIndex = 38;
            this.txtMaxPassMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxPassMod_KeyPress);
            // 
            // txtKMHMod
            // 
            this.txtKMHMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKMHMod.Location = new System.Drawing.Point(165, 264);
            this.txtKMHMod.MaxLength = 9;
            this.txtKMHMod.Name = "txtKMHMod";
            this.txtKMHMod.Size = new System.Drawing.Size(219, 19);
            this.txtKMHMod.TabIndex = 47;
            this.txtKMHMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKMHMod_KeyPress);
            // 
            // txtMinPassMod
            // 
            this.txtMinPassMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinPassMod.Location = new System.Drawing.Point(165, 31);
            this.txtMinPassMod.MaxLength = 9;
            this.txtMinPassMod.Name = "txtMinPassMod";
            this.txtMinPassMod.Size = new System.Drawing.Size(219, 19);
            this.txtMinPassMod.TabIndex = 37;
            this.txtMinPassMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinPassMod_KeyPress);
            // 
            // etqMaintMod
            // 
            this.etqMaintMod.AutoSize = true;
            this.etqMaintMod.Location = new System.Drawing.Point(36, 291);
            this.etqMaintMod.Name = "etqMaintMod";
            this.etqMaintMod.Size = new System.Drawing.Size(123, 14);
            this.etqMaintMod.TabIndex = 62;
            this.etqMaintMod.Text = "Temps de maintenance :";
            this.etqMaintMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdModAeroport
            // 
            this.cmdModAeroport.BackColor = System.Drawing.Color.Snow;
            this.cmdModAeroport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModAeroport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModAeroport.Location = new System.Drawing.Point(165, 156);
            this.cmdModAeroport.Name = "cmdModAeroport";
            this.cmdModAeroport.Size = new System.Drawing.Size(219, 31);
            this.cmdModAeroport.TabIndex = 42;
            this.cmdModAeroport.Text = "Modifier un aéroport";
            this.cmdModAeroport.UseVisualStyleBackColor = false;
            this.cmdModAeroport.Click += new System.EventHandler(this.cmdModAeroport_Click);
            this.cmdModAeroport.MouseEnter += new System.EventHandler(this.cmdModAeroport_MouseEnter);
            this.cmdModAeroport.MouseLeave += new System.EventHandler(this.cmdModAeroport_MouseLeave);
            this.cmdModAeroport.MouseHover += new System.EventHandler(this.cmdModAeroport_MouseHover);
            // 
            // txtMaintMod
            // 
            this.txtMaintMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaintMod.Location = new System.Drawing.Point(165, 289);
            this.txtMaintMod.MaxLength = 9;
            this.txtMaintMod.Name = "txtMaintMod";
            this.txtMaintMod.Size = new System.Drawing.Size(219, 19);
            this.txtMaintMod.TabIndex = 50;
            this.txtMaintMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintMod_KeyPress);
            // 
            // txtMaxMarchMod
            // 
            this.txtMaxMarchMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxMarchMod.Location = new System.Drawing.Point(165, 106);
            this.txtMaxMarchMod.MaxLength = 9;
            this.txtMaxMarchMod.Name = "txtMaxMarchMod";
            this.txtMaxMarchMod.Size = new System.Drawing.Size(219, 19);
            this.txtMaxMarchMod.TabIndex = 40;
            this.txtMaxMarchMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxMarchMod_KeyPress);
            // 
            // etqDebMod
            // 
            this.etqDebMod.AutoSize = true;
            this.etqDebMod.Location = new System.Drawing.Point(28, 341);
            this.etqDebMod.Name = "etqDebMod";
            this.etqDebMod.Size = new System.Drawing.Size(131, 14);
            this.etqDebMod.TabIndex = 61;
            this.etqDebMod.Text = "Temps de débarquement :";
            this.etqDebMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqAeroNomMod
            // 
            this.etqAeroNomMod.AutoSize = true;
            this.etqAeroNomMod.Location = new System.Drawing.Point(125, 8);
            this.etqAeroNomMod.Name = "etqAeroNomMod";
            this.etqAeroNomMod.Size = new System.Drawing.Size(34, 14);
            this.etqAeroNomMod.TabIndex = 44;
            this.etqAeroNomMod.Text = "Nom :";
            this.etqAeroNomMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqEmbMod
            // 
            this.etqEmbMod.AutoSize = true;
            this.etqEmbMod.Location = new System.Drawing.Point(33, 316);
            this.etqEmbMod.Name = "etqEmbMod";
            this.etqEmbMod.Size = new System.Drawing.Size(126, 14);
            this.etqEmbMod.TabIndex = 60;
            this.etqEmbMod.Text = "Temps d\'embarquement :";
            this.etqEmbMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinPassMod
            // 
            this.etqMinPassMod.AutoSize = true;
            this.etqMinPassMod.Location = new System.Drawing.Point(51, 33);
            this.etqMinPassMod.Name = "etqMinPassMod";
            this.etqMinPassMod.Size = new System.Drawing.Size(108, 14);
            this.etqMinPassMod.TabIndex = 45;
            this.etqMinPassMod.Text = "Minimum Passagers :";
            this.etqMinPassMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqKMHMod
            // 
            this.etqKMHMod.AutoSize = true;
            this.etqKMHMod.Location = new System.Drawing.Point(121, 266);
            this.etqKMHMod.Name = "etqKMHMod";
            this.etqKMHMod.Size = new System.Drawing.Size(38, 14);
            this.etqKMHMod.TabIndex = 59;
            this.etqKMHMod.Text = "KM/H :";
            this.etqKMHMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxPassMod
            // 
            this.etqMaxPassMod.AutoSize = true;
            this.etqMaxPassMod.Location = new System.Drawing.Point(47, 58);
            this.etqMaxPassMod.Name = "etqMaxPassMod";
            this.etqMaxPassMod.Size = new System.Drawing.Size(112, 14);
            this.etqMaxPassMod.TabIndex = 48;
            this.etqMaxPassMod.Text = "Maximum Passagers :";
            this.etqMaxPassMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqTypeMod
            // 
            this.etqTypeMod.AutoSize = true;
            this.etqTypeMod.Location = new System.Drawing.Point(123, 239);
            this.etqTypeMod.Name = "etqTypeMod";
            this.etqTypeMod.Size = new System.Drawing.Size(36, 14);
            this.etqTypeMod.TabIndex = 58;
            this.etqTypeMod.Text = "Type :";
            this.etqTypeMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinMarchMod
            // 
            this.etqMinMarchMod.AutoSize = true;
            this.etqMinMarchMod.Location = new System.Drawing.Point(35, 83);
            this.etqMinMarchMod.Name = "etqMinMarchMod";
            this.etqMinMarchMod.Size = new System.Drawing.Size(124, 14);
            this.etqMinMarchMod.TabIndex = 49;
            this.etqMinMarchMod.Text = "Minimum Marchandises :";
            this.etqMinMarchMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqVehNomMod
            // 
            this.etqVehNomMod.AutoSize = true;
            this.etqVehNomMod.Location = new System.Drawing.Point(125, 214);
            this.etqVehNomMod.Name = "etqVehNomMod";
            this.etqVehNomMod.Size = new System.Drawing.Size(34, 14);
            this.etqVehNomMod.TabIndex = 57;
            this.etqVehNomMod.Text = "Nom :";
            this.etqVehNomMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxMarchMod
            // 
            this.etqMaxMarchMod.AutoSize = true;
            this.etqMaxMarchMod.Location = new System.Drawing.Point(31, 108);
            this.etqMaxMarchMod.Name = "etqMaxMarchMod";
            this.etqMaxMarchMod.Size = new System.Drawing.Size(128, 14);
            this.etqMaxMarchMod.TabIndex = 51;
            this.etqMaxMarchMod.Text = "Maximum Marchandises :";
            this.etqMaxMarchMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDebOuLargMod
            // 
            this.txtDebOuLargMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebOuLargMod.Location = new System.Drawing.Point(165, 339);
            this.txtDebOuLargMod.MaxLength = 9;
            this.txtDebOuLargMod.Name = "txtDebOuLargMod";
            this.txtDebOuLargMod.Size = new System.Drawing.Size(219, 19);
            this.txtDebOuLargMod.TabIndex = 53;
            this.txtDebOuLargMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebOuLargMod_KeyPress);
            // 
            // txtPosMod
            // 
            this.txtPosMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosMod.Enabled = false;
            this.txtPosMod.Location = new System.Drawing.Point(165, 131);
            this.txtPosMod.Name = "txtPosMod";
            this.txtPosMod.ReadOnly = true;
            this.txtPosMod.Size = new System.Drawing.Size(219, 19);
            this.txtPosMod.TabIndex = 54;
            // 
            // cmdModVehicule
            // 
            this.cmdModVehicule.BackColor = System.Drawing.Color.Snow;
            this.cmdModVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModVehicule.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModVehicule.Location = new System.Drawing.Point(165, 364);
            this.cmdModVehicule.Name = "cmdModVehicule";
            this.cmdModVehicule.Size = new System.Drawing.Size(219, 31);
            this.cmdModVehicule.TabIndex = 55;
            this.cmdModVehicule.Text = "Modifier un véhicule";
            this.cmdModVehicule.UseVisualStyleBackColor = false;
            this.cmdModVehicule.Click += new System.EventHandler(this.cmdModVehicule_Click);
            this.cmdModVehicule.MouseEnter += new System.EventHandler(this.cmdModVehicule_MouseEnter);
            this.cmdModVehicule.MouseLeave += new System.EventHandler(this.cmdModVehicule_MouseLeave);
            this.cmdModVehicule.MouseHover += new System.EventHandler(this.cmdModVehicule_MouseHover);
            // 
            // etqPosMod
            // 
            this.etqPosMod.AutoSize = true;
            this.etqPosMod.Location = new System.Drawing.Point(25, 133);
            this.etqPosMod.Name = "etqPosMod";
            this.etqPosMod.Size = new System.Drawing.Size(134, 14);
            this.etqPosMod.TabIndex = 56;
            this.etqPosMod.Text = "Emplacement sur la carte :";
            this.etqPosMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmbOuChargMod
            // 
            this.txtEmbOuChargMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmbOuChargMod.Location = new System.Drawing.Point(165, 314);
            this.txtEmbOuChargMod.MaxLength = 9;
            this.txtEmbOuChargMod.Name = "txtEmbOuChargMod";
            this.txtEmbOuChargMod.Size = new System.Drawing.Size(219, 19);
            this.txtEmbOuChargMod.TabIndex = 52;
            this.txtEmbOuChargMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmbOuChargMod_KeyPress);
            // 
            // txtVehNomMod
            // 
            this.txtVehNomMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehNomMod.Location = new System.Drawing.Point(165, 212);
            this.txtVehNomMod.MaxLength = 100;
            this.txtVehNomMod.Name = "txtVehNomMod";
            this.txtVehNomMod.Size = new System.Drawing.Size(219, 19);
            this.txtVehNomMod.TabIndex = 43;
            this.txtVehNomMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVehNomMod_KeyPress);
            // 
            // etqChargMod
            // 
            this.etqChargMod.AutoSize = true;
            this.etqChargMod.Location = new System.Drawing.Point(40, 316);
            this.etqChargMod.Name = "etqChargMod";
            this.etqChargMod.Size = new System.Drawing.Size(119, 14);
            this.etqChargMod.TabIndex = 63;
            this.etqChargMod.Text = "Temps de chargement :";
            this.etqChargMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqLargMod
            // 
            this.etqLargMod.AutoSize = true;
            this.etqLargMod.Location = new System.Drawing.Point(61, 341);
            this.etqLargMod.Name = "etqLargMod";
            this.etqLargMod.Size = new System.Drawing.Size(98, 14);
            this.etqLargMod.TabIndex = 64;
            this.etqLargMod.Text = "Temps de largage :";
            this.etqLargMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdCarteMod
            // 
            this.cmdCarteMod.BackgroundImage = global::Generateur.Properties.Resources.pin;
            this.cmdCarteMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCarteMod.Location = new System.Drawing.Point(390, 120);
            this.cmdCarteMod.Name = "cmdCarteMod";
            this.cmdCarteMod.Size = new System.Drawing.Size(40, 40);
            this.cmdCarteMod.TabIndex = 41;
            this.cmdCarteMod.UseVisualStyleBackColor = true;
            this.cmdCarteMod.Click += new System.EventHandler(this.cmdCarteMod_Click);
            // 
            // lstAeroports
            // 
            this.lstAeroports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAeroports.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAeroports.FormattingEnabled = true;
            this.lstAeroports.ItemHeight = 15;
            this.lstAeroports.Location = new System.Drawing.Point(494, 12);
            this.lstAeroports.Name = "lstAeroports";
            this.lstAeroports.Size = new System.Drawing.Size(543, 197);
            this.lstAeroports.TabIndex = 8;
            this.lstAeroports.SelectedValueChanged += new System.EventHandler(this.lstAeroports_SelectedValueChanged);
            // 
            // lstVehicules
            // 
            this.lstVehicules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVehicules.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVehicules.FormattingEnabled = true;
            this.lstVehicules.ItemHeight = 15;
            this.lstVehicules.Location = new System.Drawing.Point(494, 257);
            this.lstVehicules.Name = "lstVehicules";
            this.lstVehicules.Size = new System.Drawing.Size(543, 197);
            this.lstVehicules.TabIndex = 16;
            this.lstVehicules.SelectedValueChanged += new System.EventHandler(this.lstVehicules_SelectedValueChanged);
            // 
            // cmdSuppAeroport
            // 
            this.cmdSuppAeroport.BackColor = System.Drawing.Color.Snow;
            this.cmdSuppAeroport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSuppAeroport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuppAeroport.Location = new System.Drawing.Point(863, 215);
            this.cmdSuppAeroport.Name = "cmdSuppAeroport";
            this.cmdSuppAeroport.Size = new System.Drawing.Size(174, 23);
            this.cmdSuppAeroport.TabIndex = 36;
            this.cmdSuppAeroport.Text = "Supprimer un aéroport";
            this.cmdSuppAeroport.UseVisualStyleBackColor = false;
            this.cmdSuppAeroport.Click += new System.EventHandler(this.cmdSuppAeroport_Click);
            // 
            // cmdSuppVehicule
            // 
            this.cmdSuppVehicule.BackColor = System.Drawing.Color.Snow;
            this.cmdSuppVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSuppVehicule.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuppVehicule.Location = new System.Drawing.Point(863, 460);
            this.cmdSuppVehicule.Name = "cmdSuppVehicule";
            this.cmdSuppVehicule.Size = new System.Drawing.Size(174, 23);
            this.cmdSuppVehicule.TabIndex = 37;
            this.cmdSuppVehicule.Text = "Supprimer un véhicule";
            this.cmdSuppVehicule.UseVisualStyleBackColor = false;
            this.cmdSuppVehicule.Click += new System.EventHandler(this.cmdSuppVehicule_Click);
            // 
            // cmdGenerer
            // 
            this.cmdGenerer.BackColor = System.Drawing.Color.Snow;
            this.cmdGenerer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerer.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerer.Location = new System.Drawing.Point(22, 484);
            this.cmdGenerer.Name = "cmdGenerer";
            this.cmdGenerer.Size = new System.Drawing.Size(451, 31);
            this.cmdGenerer.TabIndex = 36;
            this.cmdGenerer.Text = "Générer le scénario";
            this.cmdGenerer.UseVisualStyleBackColor = false;
            this.cmdGenerer.Click += new System.EventHandler(this.cmdGenerer_Click);
            this.cmdGenerer.MouseEnter += new System.EventHandler(this.cmdGenerer_MouseEnter);
            this.cmdGenerer.MouseLeave += new System.EventHandler(this.cmdGenerer_MouseLeave);
            this.cmdGenerer.MouseHover += new System.EventHandler(this.cmdGenerer_MouseHover);
            // 
            // txtGenerer
            // 
            this.txtGenerer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenerer.Location = new System.Drawing.Point(22, 460);
            this.txtGenerer.Name = "txtGenerer";
            this.txtGenerer.Size = new System.Drawing.Size(451, 19);
            this.txtGenerer.TabIndex = 38;
            this.txtGenerer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenerer_KeyPress);
            // 
            // FormGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1049, 527);
            this.Controls.Add(this.txtGenerer);
            this.Controls.Add(this.cmdGenerer);
            this.Controls.Add(this.cmdSuppVehicule);
            this.Controls.Add(this.cmdSuppAeroport);
            this.Controls.Add(this.lstVehicules);
            this.Controls.Add(this.tabGenerateur);
            this.Controls.Add(this.lstAeroports);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGenerateur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de scénarios";
            this.Load += new System.EventHandler(this.FormGenerateur_Load);
            this.tabGenerateur.ResumeLayout(false);
            this.ongAj.ResumeLayout(false);
            this.ongAj.PerformLayout();
            this.ongMod.ResumeLayout(false);
            this.ongMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAeroNom;
        private System.Windows.Forms.TextBox txtMinMarch;
        private System.Windows.Forms.TextBox txtMaxPass;
        private System.Windows.Forms.TextBox txtMinPass;
        private System.Windows.Forms.Button cmdAjAeroport;
        private System.Windows.Forms.TextBox txtMaxMarch;
        private System.Windows.Forms.Label etqAeroNom;
        private System.Windows.Forms.Label etqMinPass;
        private System.Windows.Forms.Label etqMaxPass;
        private System.Windows.Forms.Label etqMinMarch;
        private System.Windows.Forms.Label etqMaxMarch;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label etqPos;
        private System.Windows.Forms.Label etqMaint;
        private System.Windows.Forms.TextBox txtMaint;
        private System.Windows.Forms.Label etqDeb;
        private System.Windows.Forms.Label etqEmb;
        private System.Windows.Forms.Label etqKMH;
        private System.Windows.Forms.Label etqType;
        private System.Windows.Forms.Label etqVehNom;
        private System.Windows.Forms.TextBox txtDebOuLarg;
        private System.Windows.Forms.Button cmdAjVehicule;
        private System.Windows.Forms.TextBox txtEmbOuCharg;
        private System.Windows.Forms.TextBox txtVehNom;
        private System.Windows.Forms.TextBox txtKMH;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button cmdCarte;
        private System.Windows.Forms.TabControl tabGenerateur;
        private System.Windows.Forms.TabPage ongAj;
        private System.Windows.Forms.TabPage ongMod;
        private System.Windows.Forms.ListBox lstAeroports;
        private System.Windows.Forms.ListBox lstVehicules;
        private System.Windows.Forms.Label etqCharg;
        private System.Windows.Forms.Label etqLarg;
        private System.Windows.Forms.Button cmdSuppAeroport;
        private System.Windows.Forms.Button cmdSuppVehicule;
        private System.Windows.Forms.Button cmdGenerer;
        private System.Windows.Forms.TextBox txtAeroNomMod;
        private System.Windows.Forms.Button cmdCarteMod;
        private System.Windows.Forms.TextBox txtMinMarchMod;
        private System.Windows.Forms.ComboBox cmbTypeMod;
        private System.Windows.Forms.TextBox txtMaxPassMod;
        private System.Windows.Forms.TextBox txtKMHMod;
        private System.Windows.Forms.TextBox txtMinPassMod;
        private System.Windows.Forms.Label etqMaintMod;
        private System.Windows.Forms.Button cmdModAeroport;
        private System.Windows.Forms.TextBox txtMaintMod;
        private System.Windows.Forms.TextBox txtMaxMarchMod;
        private System.Windows.Forms.Label etqDebMod;
        private System.Windows.Forms.Label etqAeroNomMod;
        private System.Windows.Forms.Label etqEmbMod;
        private System.Windows.Forms.Label etqMinPassMod;
        private System.Windows.Forms.Label etqKMHMod;
        private System.Windows.Forms.Label etqMaxPassMod;
        private System.Windows.Forms.Label etqTypeMod;
        private System.Windows.Forms.Label etqMinMarchMod;
        private System.Windows.Forms.Label etqVehNomMod;
        private System.Windows.Forms.Label etqMaxMarchMod;
        private System.Windows.Forms.TextBox txtDebOuLargMod;
        private System.Windows.Forms.TextBox txtPosMod;
        private System.Windows.Forms.Button cmdModVehicule;
        private System.Windows.Forms.Label etqPosMod;
        private System.Windows.Forms.TextBox txtEmbOuChargMod;
        private System.Windows.Forms.TextBox txtVehNomMod;
        private System.Windows.Forms.Label etqChargMod;
        private System.Windows.Forms.Label etqLargMod;
        private System.Windows.Forms.TextBox txtGenerer;
    }
}


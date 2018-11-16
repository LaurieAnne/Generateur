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
            this.cmdCarte = new System.Windows.Forms.Button();
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
            this.ongMod = new System.Windows.Forms.TabPage();
            this.lstAeroports = new System.Windows.Forms.ListBox();
            this.lstVehicules = new System.Windows.Forms.ListBox();
            this.etqCharg = new System.Windows.Forms.Label();
            this.etqLarg = new System.Windows.Forms.Label();
            this.tabGenerateur.SuspendLayout();
            this.ongAj.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAeroNom
            // 
            this.txtAeroNom.Location = new System.Drawing.Point(163, 9);
            this.txtAeroNom.Name = "txtAeroNom";
            this.txtAeroNom.Size = new System.Drawing.Size(219, 19);
            this.txtAeroNom.TabIndex = 2;
            // 
            // txtMinMarch
            // 
            this.txtMinMarch.Location = new System.Drawing.Point(163, 93);
            this.txtMinMarch.Name = "txtMinMarch";
            this.txtMinMarch.Size = new System.Drawing.Size(219, 19);
            this.txtMinMarch.TabIndex = 3;
            // 
            // txtMaxPass
            // 
            this.txtMaxPass.Location = new System.Drawing.Point(163, 65);
            this.txtMaxPass.Name = "txtMaxPass";
            this.txtMaxPass.Size = new System.Drawing.Size(219, 19);
            this.txtMaxPass.TabIndex = 4;
            // 
            // txtMinPass
            // 
            this.txtMinPass.Location = new System.Drawing.Point(163, 37);
            this.txtMinPass.Name = "txtMinPass";
            this.txtMinPass.Size = new System.Drawing.Size(219, 19);
            this.txtMinPass.TabIndex = 5;
            // 
            // cmdAjAeroport
            // 
            this.cmdAjAeroport.BackColor = System.Drawing.SystemColors.Window;
            this.cmdAjAeroport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjAeroport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjAeroport.Location = new System.Drawing.Point(163, 174);
            this.cmdAjAeroport.Name = "cmdAjAeroport";
            this.cmdAjAeroport.Size = new System.Drawing.Size(219, 31);
            this.cmdAjAeroport.TabIndex = 6;
            this.cmdAjAeroport.Text = "Ajouter un aéroport";
            this.cmdAjAeroport.UseVisualStyleBackColor = false;
            this.cmdAjAeroport.Click += new System.EventHandler(this.cmdAjAeroport_Click);
            this.cmdAjAeroport.MouseEnter += new System.EventHandler(this.cmdAjAeroport_MouseEnter);
            this.cmdAjAeroport.MouseLeave += new System.EventHandler(this.cmdAjAeroport_MouseLeave);
            this.cmdAjAeroport.MouseHover += new System.EventHandler(this.cmdAjAeroport_MouseHover);
            // 
            // cmdCarte
            // 
            this.cmdCarte.BackgroundImage = global::Generateur.Properties.Resources.earth;
            this.cmdCarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCarte.Location = new System.Drawing.Point(388, 138);
            this.cmdCarte.Name = "cmdCarte";
            this.cmdCarte.Size = new System.Drawing.Size(40, 40);
            this.cmdCarte.TabIndex = 2;
            this.cmdCarte.UseVisualStyleBackColor = true;
            // 
            // txtMaxMarch
            // 
            this.txtMaxMarch.Location = new System.Drawing.Point(163, 121);
            this.txtMaxMarch.Name = "txtMaxMarch";
            this.txtMaxMarch.Size = new System.Drawing.Size(219, 19);
            this.txtMaxMarch.TabIndex = 8;
            // 
            // etqAeroNom
            // 
            this.etqAeroNom.AutoSize = true;
            this.etqAeroNom.Location = new System.Drawing.Point(123, 11);
            this.etqAeroNom.Name = "etqAeroNom";
            this.etqAeroNom.Size = new System.Drawing.Size(34, 14);
            this.etqAeroNom.TabIndex = 9;
            this.etqAeroNom.Text = "Nom :";
            this.etqAeroNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinPass
            // 
            this.etqMinPass.AutoSize = true;
            this.etqMinPass.Location = new System.Drawing.Point(49, 39);
            this.etqMinPass.Name = "etqMinPass";
            this.etqMinPass.Size = new System.Drawing.Size(108, 14);
            this.etqMinPass.TabIndex = 10;
            this.etqMinPass.Text = "Minimum Passagers :";
            this.etqMinPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxPass
            // 
            this.etqMaxPass.AutoSize = true;
            this.etqMaxPass.Location = new System.Drawing.Point(45, 67);
            this.etqMaxPass.Name = "etqMaxPass";
            this.etqMaxPass.Size = new System.Drawing.Size(112, 14);
            this.etqMaxPass.TabIndex = 11;
            this.etqMaxPass.Text = "Maximum Passagers :";
            this.etqMaxPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinMarch
            // 
            this.etqMinMarch.AutoSize = true;
            this.etqMinMarch.Location = new System.Drawing.Point(33, 95);
            this.etqMinMarch.Name = "etqMinMarch";
            this.etqMinMarch.Size = new System.Drawing.Size(124, 14);
            this.etqMinMarch.TabIndex = 12;
            this.etqMinMarch.Text = "Minimum Marchandises :";
            this.etqMinMarch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxMarch
            // 
            this.etqMaxMarch.AutoSize = true;
            this.etqMaxMarch.Location = new System.Drawing.Point(29, 123);
            this.etqMaxMarch.Name = "etqMaxMarch";
            this.etqMaxMarch.Size = new System.Drawing.Size(128, 14);
            this.etqMaxMarch.TabIndex = 13;
            this.etqMaxMarch.Text = "Maximum Marchandises :";
            this.etqMaxMarch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPos
            // 
            this.txtPos.Enabled = false;
            this.txtPos.Location = new System.Drawing.Point(163, 149);
            this.txtPos.Name = "txtPos";
            this.txtPos.ReadOnly = true;
            this.txtPos.Size = new System.Drawing.Size(219, 19);
            this.txtPos.TabIndex = 14;
            // 
            // etqPos
            // 
            this.etqPos.AutoSize = true;
            this.etqPos.Location = new System.Drawing.Point(23, 151);
            this.etqPos.Name = "etqPos";
            this.etqPos.Size = new System.Drawing.Size(134, 14);
            this.etqPos.TabIndex = 15;
            this.etqPos.Text = "Emplacement sur la carte :";
            this.etqPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaint
            // 
            this.etqMaint.AutoSize = true;
            this.etqMaint.Location = new System.Drawing.Point(34, 304);
            this.etqMaint.Name = "etqMaint";
            this.etqMaint.Size = new System.Drawing.Size(123, 14);
            this.etqMaint.TabIndex = 31;
            this.etqMaint.Text = "Temps de maintenance :";
            this.etqMaint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaint
            // 
            this.txtMaint.Location = new System.Drawing.Point(163, 302);
            this.txtMaint.Name = "txtMaint";
            this.txtMaint.Size = new System.Drawing.Size(219, 19);
            this.txtMaint.TabIndex = 30;
            // 
            // etqDeb
            // 
            this.etqDeb.AutoSize = true;
            this.etqDeb.Location = new System.Drawing.Point(26, 354);
            this.etqDeb.Name = "etqDeb";
            this.etqDeb.Size = new System.Drawing.Size(131, 14);
            this.etqDeb.TabIndex = 29;
            this.etqDeb.Text = "Temps de débarquement :";
            this.etqDeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqEmb
            // 
            this.etqEmb.AutoSize = true;
            this.etqEmb.Location = new System.Drawing.Point(31, 329);
            this.etqEmb.Name = "etqEmb";
            this.etqEmb.Size = new System.Drawing.Size(126, 14);
            this.etqEmb.TabIndex = 28;
            this.etqEmb.Text = "Temps d\'embarquement :";
            this.etqEmb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqKMH
            // 
            this.etqKMH.AutoSize = true;
            this.etqKMH.Location = new System.Drawing.Point(119, 279);
            this.etqKMH.Name = "etqKMH";
            this.etqKMH.Size = new System.Drawing.Size(38, 14);
            this.etqKMH.TabIndex = 27;
            this.etqKMH.Text = "KM/H :";
            this.etqKMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqType
            // 
            this.etqType.AutoSize = true;
            this.etqType.Location = new System.Drawing.Point(121, 252);
            this.etqType.Name = "etqType";
            this.etqType.Size = new System.Drawing.Size(36, 14);
            this.etqType.TabIndex = 26;
            this.etqType.Text = "Type :";
            this.etqType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqVehNom
            // 
            this.etqVehNom.AutoSize = true;
            this.etqVehNom.Location = new System.Drawing.Point(123, 227);
            this.etqVehNom.Name = "etqVehNom";
            this.etqVehNom.Size = new System.Drawing.Size(34, 14);
            this.etqVehNom.TabIndex = 25;
            this.etqVehNom.Text = "Nom :";
            this.etqVehNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDebOuLarg
            // 
            this.txtDebOuLarg.Location = new System.Drawing.Point(163, 352);
            this.txtDebOuLarg.Name = "txtDebOuLarg";
            this.txtDebOuLarg.Size = new System.Drawing.Size(219, 19);
            this.txtDebOuLarg.TabIndex = 24;
            // 
            // cmdAjVehicule
            // 
            this.cmdAjVehicule.BackColor = System.Drawing.SystemColors.Window;
            this.cmdAjVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjVehicule.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjVehicule.Location = new System.Drawing.Point(163, 377);
            this.cmdAjVehicule.Name = "cmdAjVehicule";
            this.cmdAjVehicule.Size = new System.Drawing.Size(219, 31);
            this.cmdAjVehicule.TabIndex = 23;
            this.cmdAjVehicule.Text = "Ajouter un véhicule";
            this.cmdAjVehicule.UseVisualStyleBackColor = false;
            this.cmdAjVehicule.Click += new System.EventHandler(this.cmdAjVehicule_Click);
            this.cmdAjVehicule.MouseEnter += new System.EventHandler(this.cmdAjVehicule_MouseEnter);
            this.cmdAjVehicule.MouseLeave += new System.EventHandler(this.cmdAjVehicule_MouseLeave);
            this.cmdAjVehicule.MouseHover += new System.EventHandler(this.cmdAjVehicule_MouseHover);
            // 
            // txtEmbOuCharg
            // 
            this.txtEmbOuCharg.Location = new System.Drawing.Point(163, 327);
            this.txtEmbOuCharg.Name = "txtEmbOuCharg";
            this.txtEmbOuCharg.Size = new System.Drawing.Size(219, 19);
            this.txtEmbOuCharg.TabIndex = 20;
            // 
            // txtVehNom
            // 
            this.txtVehNom.Location = new System.Drawing.Point(163, 225);
            this.txtVehNom.Name = "txtVehNom";
            this.txtVehNom.Size = new System.Drawing.Size(219, 19);
            this.txtVehNom.TabIndex = 19;
            // 
            // txtKMH
            // 
            this.txtKMH.Location = new System.Drawing.Point(163, 277);
            this.txtKMH.Name = "txtKMH";
            this.txtKMH.Size = new System.Drawing.Size(219, 19);
            this.txtKMH.TabIndex = 32;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(163, 250);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(219, 21);
            this.cmbType.TabIndex = 33;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // tabGenerateur
            // 
            this.tabGenerateur.Controls.Add(this.ongAj);
            this.tabGenerateur.Controls.Add(this.ongMod);
            this.tabGenerateur.Location = new System.Drawing.Point(22, 12);
            this.tabGenerateur.Name = "tabGenerateur";
            this.tabGenerateur.SelectedIndex = 0;
            this.tabGenerateur.Size = new System.Drawing.Size(451, 466);
            this.tabGenerateur.TabIndex = 34;
            // 
            // ongAj
            // 
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
            this.ongAj.Location = new System.Drawing.Point(4, 22);
            this.ongAj.Name = "ongAj";
            this.ongAj.Padding = new System.Windows.Forms.Padding(3);
            this.ongAj.Size = new System.Drawing.Size(443, 440);
            this.ongAj.TabIndex = 0;
            this.ongAj.Text = "AJOUTER";
            this.ongAj.UseVisualStyleBackColor = true;
            // 
            // ongMod
            // 
            this.ongMod.Location = new System.Drawing.Point(4, 22);
            this.ongMod.Name = "ongMod";
            this.ongMod.Padding = new System.Windows.Forms.Padding(3);
            this.ongMod.Size = new System.Drawing.Size(443, 440);
            this.ongMod.TabIndex = 1;
            this.ongMod.Text = "MODIFIER";
            this.ongMod.UseVisualStyleBackColor = true;
            // 
            // lstAeroports
            // 
            this.lstAeroports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAeroports.FormattingEnabled = true;
            this.lstAeroports.Location = new System.Drawing.Point(494, 26);
            this.lstAeroports.Name = "lstAeroports";
            this.lstAeroports.Size = new System.Drawing.Size(543, 210);
            this.lstAeroports.TabIndex = 0;
            // 
            // lstVehicules
            // 
            this.lstVehicules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVehicules.FormattingEnabled = true;
            this.lstVehicules.Location = new System.Drawing.Point(494, 255);
            this.lstVehicules.Name = "lstVehicules";
            this.lstVehicules.Size = new System.Drawing.Size(543, 210);
            this.lstVehicules.TabIndex = 1;
            // 
            // etqCharg
            // 
            this.etqCharg.AutoSize = true;
            this.etqCharg.Location = new System.Drawing.Point(38, 329);
            this.etqCharg.Name = "etqCharg";
            this.etqCharg.Size = new System.Drawing.Size(119, 14);
            this.etqCharg.TabIndex = 34;
            this.etqCharg.Text = "Temps de chargement :";
            this.etqCharg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqLarg
            // 
            this.etqLarg.AutoSize = true;
            this.etqLarg.Location = new System.Drawing.Point(59, 354);
            this.etqLarg.Name = "etqLarg";
            this.etqLarg.Size = new System.Drawing.Size(98, 14);
            this.etqLarg.TabIndex = 35;
            this.etqLarg.Text = "Temps de largage :";
            this.etqLarg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1049, 497);
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
            this.ResumeLayout(false);

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
    }
}


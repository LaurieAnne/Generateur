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
            this.pnnListes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lstVehicules = new System.Windows.Forms.ListBox();
            this.lstAeroports = new System.Windows.Forms.ListBox();
            this.txtMaxMarch = new System.Windows.Forms.TextBox();
            this.etqAeroNom = new System.Windows.Forms.Label();
            this.etqMinPass = new System.Windows.Forms.Label();
            this.etqMaxPass = new System.Windows.Forms.Label();
            this.etqMinMarch = new System.Windows.Forms.Label();
            this.etqMaxMarch = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.etqPos = new System.Windows.Forms.Label();
            this.pnnHaut = new System.Windows.Forms.Panel();
            this.pnnBas = new System.Windows.Forms.Panel();
            this.pnnGauche = new System.Windows.Forms.Panel();
            this.etqMaint = new System.Windows.Forms.Label();
            this.txtMaint = new System.Windows.Forms.TextBox();
            this.etqDeb = new System.Windows.Forms.Label();
            this.etqEmb = new System.Windows.Forms.Label();
            this.etqKMH = new System.Windows.Forms.Label();
            this.etqType = new System.Windows.Forms.Label();
            this.etqVehNom = new System.Windows.Forms.Label();
            this.txtDeb = new System.Windows.Forms.TextBox();
            this.cmdAjVehicule = new System.Windows.Forms.Button();
            this.txtEmb = new System.Windows.Forms.TextBox();
            this.txtVehNom = new System.Windows.Forms.TextBox();
            this.txtKMH = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnnListes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAeroNom
            // 
            this.txtAeroNom.Location = new System.Drawing.Point(191, 21);
            this.txtAeroNom.Name = "txtAeroNom";
            this.txtAeroNom.Size = new System.Drawing.Size(219, 19);
            this.txtAeroNom.TabIndex = 2;
            // 
            // txtMinMarch
            // 
            this.txtMinMarch.Location = new System.Drawing.Point(191, 105);
            this.txtMinMarch.Name = "txtMinMarch";
            this.txtMinMarch.Size = new System.Drawing.Size(219, 19);
            this.txtMinMarch.TabIndex = 3;
            // 
            // txtMaxPass
            // 
            this.txtMaxPass.Location = new System.Drawing.Point(191, 77);
            this.txtMaxPass.Name = "txtMaxPass";
            this.txtMaxPass.Size = new System.Drawing.Size(219, 19);
            this.txtMaxPass.TabIndex = 4;
            // 
            // txtMinPass
            // 
            this.txtMinPass.Location = new System.Drawing.Point(191, 49);
            this.txtMinPass.Name = "txtMinPass";
            this.txtMinPass.Size = new System.Drawing.Size(219, 19);
            this.txtMinPass.TabIndex = 5;
            // 
            // cmdAjAeroport
            // 
            this.cmdAjAeroport.BackColor = System.Drawing.SystemColors.Window;
            this.cmdAjAeroport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjAeroport.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjAeroport.Location = new System.Drawing.Point(191, 189);
            this.cmdAjAeroport.Name = "cmdAjAeroport";
            this.cmdAjAeroport.Size = new System.Drawing.Size(219, 31);
            this.cmdAjAeroport.TabIndex = 6;
            this.cmdAjAeroport.Text = "Ajouter un aéroport";
            this.cmdAjAeroport.UseVisualStyleBackColor = false;
            this.cmdAjAeroport.MouseEnter += new System.EventHandler(this.cmdAjAeroport_MouseEnter);
            this.cmdAjAeroport.MouseLeave += new System.EventHandler(this.cmdAjAeroport_MouseLeave);
            this.cmdAjAeroport.MouseHover += new System.EventHandler(this.cmdAjAeroport_MouseHover);
            // 
            // pnnListes
            // 
            this.pnnListes.BackColor = System.Drawing.Color.SkyBlue;
            this.pnnListes.Controls.Add(this.lstVehicules);
            this.pnnListes.Controls.Add(this.lstAeroports);
            this.pnnListes.Location = new System.Drawing.Point(466, 0);
            this.pnnListes.Name = "pnnListes";
            this.pnnListes.Size = new System.Drawing.Size(583, 482);
            this.pnnListes.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Generateur.Properties.Resources.earth;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(416, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstVehicules
            // 
            this.lstVehicules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVehicules.FormattingEnabled = true;
            this.lstVehicules.Location = new System.Drawing.Point(19, 239);
            this.lstVehicules.Name = "lstVehicules";
            this.lstVehicules.Size = new System.Drawing.Size(543, 210);
            this.lstVehicules.TabIndex = 1;
            // 
            // lstAeroports
            // 
            this.lstAeroports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAeroports.FormattingEnabled = true;
            this.lstAeroports.Location = new System.Drawing.Point(19, 21);
            this.lstAeroports.Name = "lstAeroports";
            this.lstAeroports.Size = new System.Drawing.Size(543, 210);
            this.lstAeroports.TabIndex = 0;
            // 
            // txtMaxMarch
            // 
            this.txtMaxMarch.Location = new System.Drawing.Point(191, 133);
            this.txtMaxMarch.Name = "txtMaxMarch";
            this.txtMaxMarch.Size = new System.Drawing.Size(219, 19);
            this.txtMaxMarch.TabIndex = 8;
            // 
            // etqAeroNom
            // 
            this.etqAeroNom.AutoSize = true;
            this.etqAeroNom.Location = new System.Drawing.Point(151, 23);
            this.etqAeroNom.Name = "etqAeroNom";
            this.etqAeroNom.Size = new System.Drawing.Size(34, 14);
            this.etqAeroNom.TabIndex = 9;
            this.etqAeroNom.Text = "Nom :";
            this.etqAeroNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinPass
            // 
            this.etqMinPass.AutoSize = true;
            this.etqMinPass.Location = new System.Drawing.Point(77, 51);
            this.etqMinPass.Name = "etqMinPass";
            this.etqMinPass.Size = new System.Drawing.Size(108, 14);
            this.etqMinPass.TabIndex = 10;
            this.etqMinPass.Text = "Minimum Passagers :";
            this.etqMinPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxPass
            // 
            this.etqMaxPass.AutoSize = true;
            this.etqMaxPass.Location = new System.Drawing.Point(73, 79);
            this.etqMaxPass.Name = "etqMaxPass";
            this.etqMaxPass.Size = new System.Drawing.Size(112, 14);
            this.etqMaxPass.TabIndex = 11;
            this.etqMaxPass.Text = "Maximum Passagers :";
            this.etqMaxPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMinMarch
            // 
            this.etqMinMarch.AutoSize = true;
            this.etqMinMarch.Location = new System.Drawing.Point(61, 107);
            this.etqMinMarch.Name = "etqMinMarch";
            this.etqMinMarch.Size = new System.Drawing.Size(124, 14);
            this.etqMinMarch.TabIndex = 12;
            this.etqMinMarch.Text = "Minimum Marchandises :";
            this.etqMinMarch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqMaxMarch
            // 
            this.etqMaxMarch.AutoSize = true;
            this.etqMaxMarch.Location = new System.Drawing.Point(57, 135);
            this.etqMaxMarch.Name = "etqMaxMarch";
            this.etqMaxMarch.Size = new System.Drawing.Size(128, 14);
            this.etqMaxMarch.TabIndex = 13;
            this.etqMaxMarch.Text = "Maximum Marchandises :";
            this.etqMaxMarch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(191, 161);
            this.txtPos.Name = "txtPos";
            this.txtPos.ReadOnly = true;
            this.txtPos.Size = new System.Drawing.Size(219, 19);
            this.txtPos.TabIndex = 14;
            // 
            // etqPos
            // 
            this.etqPos.AutoSize = true;
            this.etqPos.Location = new System.Drawing.Point(51, 163);
            this.etqPos.Name = "etqPos";
            this.etqPos.Size = new System.Drawing.Size(134, 14);
            this.etqPos.TabIndex = 15;
            this.etqPos.Text = "Emplacement sur la carte :";
            this.etqPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnnHaut
            // 
            this.pnnHaut.BackColor = System.Drawing.Color.SkyBlue;
            this.pnnHaut.Location = new System.Drawing.Point(0, 0);
            this.pnnHaut.Name = "pnnHaut";
            this.pnnHaut.Size = new System.Drawing.Size(479, 15);
            this.pnnHaut.TabIndex = 16;
            // 
            // pnnBas
            // 
            this.pnnBas.BackColor = System.Drawing.Color.SkyBlue;
            this.pnnBas.Location = new System.Drawing.Point(0, 467);
            this.pnnBas.Name = "pnnBas";
            this.pnnBas.Size = new System.Drawing.Size(479, 15);
            this.pnnBas.TabIndex = 17;
            // 
            // pnnGauche
            // 
            this.pnnGauche.BackColor = System.Drawing.Color.SkyBlue;
            this.pnnGauche.Location = new System.Drawing.Point(0, 12);
            this.pnnGauche.Name = "pnnGauche";
            this.pnnGauche.Size = new System.Drawing.Size(16, 456);
            this.pnnGauche.TabIndex = 18;
            // 
            // etqMaint
            // 
            this.etqMaint.AutoSize = true;
            this.etqMaint.Location = new System.Drawing.Point(62, 381);
            this.etqMaint.Name = "etqMaint";
            this.etqMaint.Size = new System.Drawing.Size(123, 14);
            this.etqMaint.TabIndex = 31;
            this.etqMaint.Text = "Temps de maintenance :";
            this.etqMaint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaint
            // 
            this.txtMaint.Location = new System.Drawing.Point(191, 379);
            this.txtMaint.Name = "txtMaint";
            this.txtMaint.Size = new System.Drawing.Size(219, 19);
            this.txtMaint.TabIndex = 30;
            // 
            // etqDeb
            // 
            this.etqDeb.AutoSize = true;
            this.etqDeb.Location = new System.Drawing.Point(54, 353);
            this.etqDeb.Name = "etqDeb";
            this.etqDeb.Size = new System.Drawing.Size(131, 14);
            this.etqDeb.TabIndex = 29;
            this.etqDeb.Text = "Temps de débarquement :";
            this.etqDeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqEmb
            // 
            this.etqEmb.AutoSize = true;
            this.etqEmb.Location = new System.Drawing.Point(59, 325);
            this.etqEmb.Name = "etqEmb";
            this.etqEmb.Size = new System.Drawing.Size(126, 14);
            this.etqEmb.TabIndex = 28;
            this.etqEmb.Text = "Temps d\'embarquement :";
            this.etqEmb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqKMH
            // 
            this.etqKMH.AutoSize = true;
            this.etqKMH.Location = new System.Drawing.Point(147, 297);
            this.etqKMH.Name = "etqKMH";
            this.etqKMH.Size = new System.Drawing.Size(38, 14);
            this.etqKMH.TabIndex = 27;
            this.etqKMH.Text = "KM/H :";
            this.etqKMH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqType
            // 
            this.etqType.AutoSize = true;
            this.etqType.Location = new System.Drawing.Point(149, 270);
            this.etqType.Name = "etqType";
            this.etqType.Size = new System.Drawing.Size(36, 14);
            this.etqType.TabIndex = 26;
            this.etqType.Text = "Type :";
            this.etqType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etqVehNom
            // 
            this.etqVehNom.AutoSize = true;
            this.etqVehNom.Location = new System.Drawing.Point(151, 245);
            this.etqVehNom.Name = "etqVehNom";
            this.etqVehNom.Size = new System.Drawing.Size(34, 14);
            this.etqVehNom.TabIndex = 25;
            this.etqVehNom.Text = "Nom :";
            this.etqVehNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeb
            // 
            this.txtDeb.Location = new System.Drawing.Point(191, 351);
            this.txtDeb.Name = "txtDeb";
            this.txtDeb.Size = new System.Drawing.Size(219, 19);
            this.txtDeb.TabIndex = 24;
            // 
            // cmdAjVehicule
            // 
            this.cmdAjVehicule.BackColor = System.Drawing.SystemColors.Window;
            this.cmdAjVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAjVehicule.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjVehicule.Location = new System.Drawing.Point(191, 407);
            this.cmdAjVehicule.Name = "cmdAjVehicule";
            this.cmdAjVehicule.Size = new System.Drawing.Size(219, 31);
            this.cmdAjVehicule.TabIndex = 23;
            this.cmdAjVehicule.Text = "Ajouter un véhicule";
            this.cmdAjVehicule.UseVisualStyleBackColor = false;
            this.cmdAjVehicule.MouseEnter += new System.EventHandler(this.cmdAjVehicule_MouseEnter);
            this.cmdAjVehicule.MouseLeave += new System.EventHandler(this.cmdAjVehicule_MouseLeave);
            this.cmdAjVehicule.MouseHover += new System.EventHandler(this.cmdAjVehicule_MouseHover);
            // 
            // txtEmb
            // 
            this.txtEmb.Location = new System.Drawing.Point(191, 323);
            this.txtEmb.Name = "txtEmb";
            this.txtEmb.Size = new System.Drawing.Size(219, 19);
            this.txtEmb.TabIndex = 20;
            // 
            // txtVehNom
            // 
            this.txtVehNom.Location = new System.Drawing.Point(191, 243);
            this.txtVehNom.Name = "txtVehNom";
            this.txtVehNom.Size = new System.Drawing.Size(219, 19);
            this.txtVehNom.TabIndex = 19;
            // 
            // txtKMH
            // 
            this.txtKMH.Location = new System.Drawing.Point(191, 295);
            this.txtKMH.Name = "txtKMH";
            this.txtKMH.Size = new System.Drawing.Size(219, 19);
            this.txtKMH.TabIndex = 32;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(191, 268);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(219, 21);
            this.cmbType.TabIndex = 33;
            // 
            // FormGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1049, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtKMH);
            this.Controls.Add(this.etqMaint);
            this.Controls.Add(this.txtMaint);
            this.Controls.Add(this.etqDeb);
            this.Controls.Add(this.etqEmb);
            this.Controls.Add(this.etqKMH);
            this.Controls.Add(this.etqType);
            this.Controls.Add(this.etqVehNom);
            this.Controls.Add(this.txtDeb);
            this.Controls.Add(this.cmdAjVehicule);
            this.Controls.Add(this.txtEmb);
            this.Controls.Add(this.txtVehNom);
            this.Controls.Add(this.etqPos);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.etqMaxMarch);
            this.Controls.Add(this.etqMinMarch);
            this.Controls.Add(this.etqMaxPass);
            this.Controls.Add(this.etqMinPass);
            this.Controls.Add(this.etqAeroNom);
            this.Controls.Add(this.txtMaxMarch);
            this.Controls.Add(this.cmdAjAeroport);
            this.Controls.Add(this.txtMinPass);
            this.Controls.Add(this.txtMaxPass);
            this.Controls.Add(this.txtMinMarch);
            this.Controls.Add(this.txtAeroNom);
            this.Controls.Add(this.pnnListes);
            this.Controls.Add(this.pnnHaut);
            this.Controls.Add(this.pnnBas);
            this.Controls.Add(this.pnnGauche);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGenerateur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de scénarios";
            this.Load += new System.EventHandler(this.FormGenerateur_Load);
            this.pnnListes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAeroNom;
        private System.Windows.Forms.TextBox txtMinMarch;
        private System.Windows.Forms.TextBox txtMaxPass;
        private System.Windows.Forms.TextBox txtMinPass;
        private System.Windows.Forms.Button cmdAjAeroport;
        private System.Windows.Forms.Panel pnnListes;
        private System.Windows.Forms.ListBox lstVehicules;
        private System.Windows.Forms.ListBox lstAeroports;
        private System.Windows.Forms.TextBox txtMaxMarch;
        private System.Windows.Forms.Label etqAeroNom;
        private System.Windows.Forms.Label etqMinPass;
        private System.Windows.Forms.Label etqMaxPass;
        private System.Windows.Forms.Label etqMinMarch;
        private System.Windows.Forms.Label etqMaxMarch;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label etqPos;
        private System.Windows.Forms.Panel pnnHaut;
        private System.Windows.Forms.Panel pnnBas;
        private System.Windows.Forms.Panel pnnGauche;
        private System.Windows.Forms.Label etqMaint;
        private System.Windows.Forms.TextBox txtMaint;
        private System.Windows.Forms.Label etqDeb;
        private System.Windows.Forms.Label etqEmb;
        private System.Windows.Forms.Label etqKMH;
        private System.Windows.Forms.Label etqType;
        private System.Windows.Forms.Label etqVehNom;
        private System.Windows.Forms.TextBox txtDeb;
        private System.Windows.Forms.Button cmdAjVehicule;
        private System.Windows.Forms.TextBox txtEmb;
        private System.Windows.Forms.TextBox txtVehNom;
        private System.Windows.Forms.TextBox txtKMH;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button button1;
    }
}


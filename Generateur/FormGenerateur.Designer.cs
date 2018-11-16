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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstVehicules = new System.Windows.Forms.ListBox();
            this.lstAeroports = new System.Windows.Forms.ListBox();
            this.txtMaxMarch = new System.Windows.Forms.TextBox();
            this.etqAeroNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAeroNom
            // 
            this.txtAeroNom.Location = new System.Drawing.Point(191, 21);
            this.txtAeroNom.Name = "txtAeroNom";
            this.txtAeroNom.Size = new System.Drawing.Size(219, 22);
            this.txtAeroNom.TabIndex = 2;
            // 
            // txtMinMarch
            // 
            this.txtMinMarch.Location = new System.Drawing.Point(191, 105);
            this.txtMinMarch.Name = "txtMinMarch";
            this.txtMinMarch.Size = new System.Drawing.Size(219, 22);
            this.txtMinMarch.TabIndex = 3;
            // 
            // txtMaxPass
            // 
            this.txtMaxPass.Location = new System.Drawing.Point(191, 77);
            this.txtMaxPass.Name = "txtMaxPass";
            this.txtMaxPass.Size = new System.Drawing.Size(219, 22);
            this.txtMaxPass.TabIndex = 4;
            // 
            // txtMinPass
            // 
            this.txtMinPass.Location = new System.Drawing.Point(191, 49);
            this.txtMinPass.Name = "txtMinPass";
            this.txtMinPass.Size = new System.Drawing.Size(219, 22);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lstVehicules);
            this.panel1.Controls.Add(this.lstAeroports);
            this.panel1.Location = new System.Drawing.Point(466, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 482);
            this.panel1.TabIndex = 7;
            // 
            // lstVehicules
            // 
            this.lstVehicules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVehicules.FormattingEnabled = true;
            this.lstVehicules.ItemHeight = 16;
            this.lstVehicules.Location = new System.Drawing.Point(19, 239);
            this.lstVehicules.Name = "lstVehicules";
            this.lstVehicules.Size = new System.Drawing.Size(543, 210);
            this.lstVehicules.TabIndex = 1;
            // 
            // lstAeroports
            // 
            this.lstAeroports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAeroports.FormattingEnabled = true;
            this.lstAeroports.ItemHeight = 16;
            this.lstAeroports.Location = new System.Drawing.Point(19, 21);
            this.lstAeroports.Name = "lstAeroports";
            this.lstAeroports.Size = new System.Drawing.Size(543, 210);
            this.lstAeroports.TabIndex = 0;
            // 
            // txtMaxMarch
            // 
            this.txtMaxMarch.Location = new System.Drawing.Point(191, 133);
            this.txtMaxMarch.Name = "txtMaxMarch";
            this.txtMaxMarch.Size = new System.Drawing.Size(219, 22);
            this.txtMaxMarch.TabIndex = 8;
            // 
            // etqAeroNom
            // 
            this.etqAeroNom.AutoSize = true;
            this.etqAeroNom.Location = new System.Drawing.Point(141, 24);
            this.etqAeroNom.Name = "etqAeroNom";
            this.etqAeroNom.Size = new System.Drawing.Size(44, 16);
            this.etqAeroNom.TabIndex = 9;
            this.etqAeroNom.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minimum Passagers :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Maximum Passagers :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Minimum Marchandises :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maximum Marchandises :";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(191, 161);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(219, 22);
            this.txtPos.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Emplacement sur la carte :";
            // 
            // FormGenerateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1049, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etqAeroNom);
            this.Controls.Add(this.txtMaxMarch);
            this.Controls.Add(this.cmdAjAeroport);
            this.Controls.Add(this.txtMinPass);
            this.Controls.Add(this.txtMaxPass);
            this.Controls.Add(this.txtMinMarch);
            this.Controls.Add(this.txtAeroNom);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGenerateur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de scénarios";
            this.Load += new System.EventHandler(this.FormGenerateur_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAeroNom;
        private System.Windows.Forms.TextBox txtMinMarch;
        private System.Windows.Forms.TextBox txtMaxPass;
        private System.Windows.Forms.TextBox txtMinPass;
        private System.Windows.Forms.Button cmdAjAeroport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstVehicules;
        private System.Windows.Forms.ListBox lstAeroports;
        private System.Windows.Forms.TextBox txtMaxMarch;
        private System.Windows.Forms.Label etqAeroNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label1;
    }
}


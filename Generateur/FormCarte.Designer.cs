namespace Generateur
{
    partial class FormCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarte));
            this.imgCarte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCarte
            // 
            this.imgCarte.Image = ((System.Drawing.Image)(resources.GetObject("imgCarte.Image")));
            this.imgCarte.Location = new System.Drawing.Point(12, 12);
            this.imgCarte.Name = "imgCarte";
            this.imgCarte.Size = new System.Drawing.Size(900, 528);
            this.imgCarte.TabIndex = 0;
            this.imgCarte.TabStop = false;
            this.imgCarte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgCarte_MouseDown);
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.imgCarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choisissez l\'emplacement";
            ((System.ComponentModel.ISupportInitialize)(this.imgCarte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCarte;
    }
}
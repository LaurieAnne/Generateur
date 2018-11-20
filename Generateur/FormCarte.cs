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
    public partial class FormCarte : Form
    {
        FormGenerateur m_gen; //Le générateur

        public FormCarte(FormGenerateur p_gen) //Constructeur
        {
            InitializeComponent();
            m_gen = p_gen;
        }

        private void imgCarte_MouseDown(object sender, MouseEventArgs e) //Récupérer le x et le y
        {
            int x = e.X;
            int y = e.Y;
            int[] taille = new int[2];
            taille[0] = imgCarte.Width;
            taille[1] = imgCarte.Height;
            m_gen.afficherPos(x, y, taille);
            this.Close();
        }
    }
}

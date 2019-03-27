using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JogoGalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            galo Galo = new galo();

            Galo.MdiParent = this;

            Galo.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabelaDeVitoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pontos pontos = new Pontos();
            pontos.ShowDialog();
        }
    }
}


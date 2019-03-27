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
    public partial class Pontos : Form
    {
        public Pontos()
        {
            InitializeComponent();
            listBox1.DataSource = System.IO.File.ReadAllLines("jogo.txt");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pontos_Load(object sender, EventArgs e)
        {

        }
    }
}

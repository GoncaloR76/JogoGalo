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
    public partial class galo : Form
    {
        public galo()
        {
            InitializeComponent();
        }

        string Turno = "Jogador1";
        string texto;
        
        private void galo_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
             if (btn1.Text != "" )
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn1.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn1.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (btn2.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn2.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn2.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if (btn3.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn3.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn3.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn6.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn6.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn5.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn5.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (btn4.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn4.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn4.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção","Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn7.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn7.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn8.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn8.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);

                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text != "")
            {
                Resultado(texto);
                MessageBox.Show("Atenção,Posição ocupada!");
            }
            else
            {
                if (Turno == "Jogador1")
                {
                    btn9.Text = "X";
                    Turno = "Jogador2";
                    Resultado(texto);
                }
                else if (Turno == "Jogador2")
                {
                    btn9.Text = "O";
                    Turno = "Jogador1";
                    Resultado(texto);
                }
            }
        }

        
        void Resultado(string player)
        {

            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" || btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" || btn7.Text == "X" && btn5.Text == "X" && btn3.Text == "X" || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Atenção,O jogador1 ganhou");
                player = "Jogador1";
                Texto(player);
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" || btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" || btn7.Text == "O" && btn5.Text == "O" && btn3.Text == "O" || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Atenção,O jogador2 ganhou");
                player = "Jogador2";
                Texto(player);
            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Atenção,empate");
                Resultado(texto);

            }

        }

        public void Texto(string player)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("jogo.txt", true);
            file.WriteLine(player);
            file.Close();
        }
        
    }
}


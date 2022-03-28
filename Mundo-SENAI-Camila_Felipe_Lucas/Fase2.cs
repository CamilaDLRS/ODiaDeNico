using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Mundo_SENAI_Camila_Felipe_Lucas
{
    public partial class Fase2 : Form
    {

        Audios sons = new Audios();

        Cozinha atributos2 = new Cozinha();

        public Fase2()
        {
            InitializeComponent();
        }


        private void pbProximo_Click(object sender, EventArgs e)
        {
            sons.prato.Play();
            MessageBox.Show("Clique no prato!!");
        }

        private void pbSanduiche_Click(object sender, EventArgs e)
        {
            pbSanduiche.Enabled = false;
            atributos2.sanduiche = false;
            pbSanduiche.Image = null;
            atributos2.contador += 1;
        }

        private void pbCerveja_Click(object sender, EventArgs e)
        {
            pbCerveja.Enabled = false;
            atributos2.cerveja = false;
            pbCerveja.Image = null;
        }

        private void pbPizza_Click(object sender, EventArgs e)
        {
            pbPizza.Enabled = false;
            atributos2.pizza = false;
            pbPizza.Image = null;
        }

        private void pbBolinho_Click(object sender, EventArgs e)
        {
            pbBolinho.Enabled = false;
            atributos2.bolinho = false;
            pbBolinho.Image = null;
        }

        private void pbSuquinho_Click(object sender, EventArgs e)
        {
            pbSuquinho.Enabled = false;
            atributos2.suquinho = false;
            pbSuquinho.Image = null;
            atributos2.contador += 1;
        }

        private void pbFruta_Click(object sender, EventArgs e)
        {
            pbFruta.Enabled = false;
            atributos2.maca = false;
            pbFruta.Image = null;
            atributos2.contador += 1;
        }

        private void pbPrato_Click(object sender, EventArgs e)
        {
            if (atributos2.sanduiche == false && atributos2.suquinho == false && atributos2.pizza == true && atributos2.cerveja == true && atributos2.bolinho == true && atributos2.maca == false)
            {
                pbPrato.Image = Properties.Resources.prato_cheio;
                sons.fase2_acertou.Play();
                MessageBox.Show("Parabéns você selecionou os alimentos corretos.\nSe prepare para ir organizar sua Mochila.", "A caminho da Mochila");
                Fase3 proximo = new Fase3();
                this.Hide();
                proximo.ShowDialog();
                this.Close();
            }

            else if (atributos2.contador < 3 && pbBolinho.Enabled == true && pbCerveja.Enabled == true && pbPizza.Enabled == true)
            {
                sons.fase2_esqueceu.Play();
                MessageBox.Show("Você esta esquecendo alguma comida...");
            }

            else
            {
                sons.fase2_errou.Play();
                MessageBox.Show("Há algo ai que não pertence ao café da manhã.", "Você se confundiu");

                atributos2.suquinho = true;
                atributos2.sanduiche = true;
                atributos2.pizza = true;
                atributos2.cerveja = true;
                atributos2.bolinho = true;
                atributos2.maca = true;
                atributos2.contador = 0;

                pbSuquinho.Enabled = true;
                pbSanduiche.Enabled = true;
                pbPizza.Enabled = true;
                pbFruta.Enabled = true;
                pbCerveja.Enabled = true;
                pbBolinho.Enabled = true;

                pbSuquinho.Image = Properties.Resources.siquinho;
                pbPizza.Image = Properties.Resources.oizza;
                pbCerveja.Image = Properties.Resources.cerveja;
                pbBolinho.Image = Properties.Resources.PinkCupcakedddd;
                pbSanduiche.Image = Properties.Resources.sandwich_155786_640;
                pbFruta.Image = Properties.Resources.maca1;
            }
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase2.Play();
        }
    }
}

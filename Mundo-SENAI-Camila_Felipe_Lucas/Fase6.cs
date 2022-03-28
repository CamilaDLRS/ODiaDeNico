using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mundo_SENAI_Camila_Felipe_Lucas
{
    public partial class Fase6 : Form
    {
        Audios sons = new Audios();

        Quarto atributos6 = new Quarto();

        public Fase6()
        {
            InitializeComponent();
        }

        private void pbBau_Click(object sender, EventArgs e)
        {
            if (atributos6.aviao == true && atributos6.fusca == true && atributos6.trem == true && atributos6.bola == true && atributos6.ursinho == true)
            {
                pbBau.Image = Properties.Resources.briquedos;
                atributos6.proximo = true;
            }

            else
            {
                sons.fase6_errou.Play();

                MessageBox.Show("Você deve ter esquecido de algum brinquedo, continue procurando.");

                atributos6.aviao = false;
                atributos6.trem = false;
                atributos6.bola = false;
                atributos6.bau = false;
                atributos6.ursinho = false;
                atributos6.fusca = false;

                pbFusca.Image = Properties.Resources.brinquedo;
                pbBola.Image = Properties.Resources.bola_de_prai;
                pbTrem.Image = Properties.Resources.trem;
                pbUrsinho.Image = Properties.Resources.ursinho;
                pbAviao.Image = Properties.Resources.aviao;
            }
        }

        private void pbAviao_Click(object sender, EventArgs e)
        {
            atributos6.aviao = true;
            pbAviao.Image = null;
        }

        private void pbFusca_Click(object sender, EventArgs e)
        {
            atributos6.fusca = true;
            pbFusca.Image = null;
        }

        private void pbTrem_Click(object sender, EventArgs e)
        {
            atributos6.trem = true;
            pbTrem.Image = null;
        }

        private void pbBola_Click(object sender, EventArgs e)
        {
            atributos6.bola = true;
            pbBola.Image = null;
        }

        private void pbUrsinho_Click(object sender, EventArgs e)
        {
            atributos6.ursinho = true;
            pbUrsinho.Image = null;
        }

        private void pbProximo_Click(object sender, EventArgs e)
        {
            if (atributos6.proximo == true)
            {
                MessageBox.Show("Parabéns, agora Nico pode ir dormir!");

                sons.bau.Stop();
                sons.fase6.Stop();
                

                Creditos proximo = new Creditos();
                this.Hide();
                proximo.ShowDialog();
                this.Close();
            }

            else
            {
                sons.bau.Play();
                MessageBox.Show("clique no baú!");
            }
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase6.Play();
        }
    }
}

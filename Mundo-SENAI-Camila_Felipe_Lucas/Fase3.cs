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
    public partial class Fase3 : Form
    {
        Audios sons = new Audios();

        Mochila atributos3 = new Mochila();

        public Fase3()
        {
            InitializeComponent();
        }

        private void pbProximo_Click(object sender, EventArgs e)
        {
            sons.mochila.Play();
            MessageBox.Show("Clique na mochila!!");
        }

        private void pbTelefone_Click(object sender, EventArgs e)
        {
            pbTelefone.Enabled = false;
            pbTelefone.Image = null;
            atributos3.telefone = false;
        }

        private void pbRegua_Click(object sender, EventArgs e)
        {
            pbRegua.Enabled = false;
            pbRegua.Image = null;
            atributos3.regua = false;
            atributos3.contador += 1;
        }

        private void pbMaionese_Click(object sender, EventArgs e)
        {
            pbMaionese.Enabled = false;
            pbMaionese.Image = null;
            atributos3.poteMaionese = false;
        }

        private void pbEstensao_Click(object sender, EventArgs e)
        {
            pbEstensao.Enabled = false;
            pbEstensao.Image = null;
            atributos3.estensao = false;
        }

        private void pbLivros_Click(object sender, EventArgs e)
        {
            pbLivros.Enabled = false;
            pbLivros.Image = null;
            atributos3.livros = false;
            atributos3.contador += 1;
        }

        private void pbPlanta_Click(object sender, EventArgs e)
        {
            pbPlanta.Enabled = false;
            pbPlanta.Image = null;
            atributos3.vasoPlanta = false;
        }

        private void pbApontador_Click(object sender, EventArgs e)
        {
            pbApontador.Enabled = false;
            pbApontador.Image = null;
            atributos3.apontador = false;
            atributos3.contador += 1;
        }

        private void pbGiz_Click(object sender, EventArgs e)
        {
            pbGiz.Enabled = false;
            pbGiz.Image = null;
            atributos3.giz = false;
            atributos3.contador += 1;
        }

        private void pbMochila_Click(object sender, EventArgs e)
        {
            if (atributos3.telefone = true && atributos3.regua == false && atributos3.livros == false && atributos3.poteMaionese == true && atributos3.giz == false && atributos3.estensao == true && atributos3.apontador == false && atributos3.vasoPlanta == true)
            {
                pbMochila.Image = Properties.Resources.mochila_cheio;
                sons.fase3_acertou.Play();
                MessageBox.Show("Uau você organizou bem!!!\nAgora você está pronto para ir a escola.", "A caminho da Escola");
                Escola proximo = new Escola();
                this.Hide();
                proximo.ShowDialog();
                this.Close();
            }

            else if (atributos3.contador < 4 && pbTelefone.Enabled == true && pbPlanta.Enabled == true && pbMaionese.Enabled == true && pbEstensao.Enabled == true)
            {
                sons.fase3_esqueceu.Play();
                MessageBox.Show("Você deve ter esquecido algum material.");
            }

            else
            {
                sons.fase3_errou.Play();
                MessageBox.Show("Opa, parece que você está levando algo que não devia.", "Cuidado");

                pbTelefone.Image = Properties.Resources.telefone;
                pbEstensao.Image = Properties.Resources.estenção;
                pbMaionese.Image = Properties.Resources.maionese;
                pbPlanta.Image = Properties.Resources.platinha;
                pbApontador.Image = Properties.Resources.apontador;
                pbLivros.Image = Properties.Resources.livros;
                pbRegua.Image = Properties.Resources.Regua;
                pbGiz.Image = Properties.Resources.giz;

                atributos3.telefone = true;
                atributos3.estensao = true;
                atributos3.poteMaionese = true;
                atributos3.vasoPlanta = true;
                atributos3.apontador = true;
                atributos3.livros = true;
                atributos3.regua = true;
                atributos3.giz = true;
                atributos3.contador = 0;

                pbApontador.Enabled = true;
                pbEstensao.Enabled = true;
                pbGiz.Enabled = true;
                pbLivros.Enabled = true;
                pbMaionese.Enabled = true;
                pbMochila.Enabled = true;
                pbPlanta.Enabled = true;
                pbRegua.Enabled = true;
                pbTelefone.Enabled = true;
                
            }
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase3.Play();
        }
    }
}

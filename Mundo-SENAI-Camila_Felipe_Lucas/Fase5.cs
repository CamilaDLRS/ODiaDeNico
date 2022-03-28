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
    public partial class Fase5 : Form
    {
        Audios sons = new Audios();

        Mercado atributos5 = new Mercado();

        public Fase5()
        {
            InitializeComponent();
        }

        private void pbProximo_Click(object sender, EventArgs e)
        {
            if (atributos5.biscoito == false && atributos5.geleiaPera == true && atributos5.iogurte == false && atributos5.leite == true
                && atributos5.geleiaLaranja == false && atributos5.geleiaCereja == false && atributos5.sucoLaranja == true
                && atributos5.geleiaMorango == false && atributos5.refrigerante == false && atributos5.IogurteLimao == false && atributos5.ketchup == true)
            {
                sons.fase5_acertou.Play();
                
                MessageBox.Show("Parabéns, está na hora de ir pra casa!", "Caminho a casa");
                Fase6 proximo = new Fase6();
                this.Hide();
                proximo.ShowDialog();
                this.Close();
            }

            else if (atributos5.contador < 4 && pbBiscoito.Image == null && pbGeleiaCareja.Image == null && pbGeleiaLaranja.Image == null && pbGeleiaMorango.Image == null && pbIogurte.Image == null && pbIogurteLimao.Image == null && pbRefrigerente.Image == null)
            {
                sons.fase5_esqueceu.Play();
                MessageBox.Show("A lista não está completa, continue comprando...");
            }

            else
            {
                sons.fase5_errou.Play();

                MessageBox.Show("Você não seguiu a lista corretamente. Tente novamente!!");

                atributos5.ketchup = false;
                atributos5.geleiaPera = false;          
                atributos5.leite = false;
                atributos5.sucoLaranja = false;
                atributos5.biscoito = false;
                atributos5.iogurte = false;
                atributos5.geleiaLaranja = false;
                atributos5.geleiaCereja = false;
                atributos5.geleiaMorango = false;
                atributos5.refrigerante = false;
                atributos5.IogurteLimao = false;
                atributos5.contador = 0;

                pbSucoLaranja.Enabled = true;
                pbGeleiaPera.Enabled = true;
                pbKetchup.Enabled = true;
                pbLeite.Enabled = true;

                pbSucoCerto.Image = null;
                pbPeraCerto.Image = null;
                pbKetchupCerto.Image = null;
                pbLeiteCerto.Image = null;
                pbBiscoito.Image = null;
                pbGeleiaPera.Image = null;
                pbIogurte.Image = null;
                pbIogurteLimao.Image = null;
                pbLeite.Image = null;
                pbRefrigerente.Image = null;
                pbGeleiaLaranja.Image = null;
                pbGeleiaCareja.Image = null;
                pbSucoLaranja.Image = null;
                pbGeleiaMorango.Image = null;
                pbKetchup.Image = null;
            }
        }

        private void pbKetchup_Click(object sender, EventArgs e)
        {
            atributos5.ketchup = true;
            pbKetchupCerto.Image = Properties.Resources.certo_simbolo;
            pbKetchup.Image = Properties.Resources.certo_simbolo;
            atributos5.contador += 1;
            pbKetchup.Enabled = false;
        }

        private void pbGeleiaPera_Click(object sender, EventArgs e)
        {
            atributos5.geleiaPera = true;
            pbPeraCerto.Image = Properties.Resources.certo_simbolo;
            pbGeleiaPera.Image = Properties.Resources.certo_simbolo;
            atributos5.contador += 1;
            pbGeleiaPera.Enabled = false;
        }

        private void pbLeite_Click(object sender, EventArgs e)
        {
            atributos5.leite = true;
            pbLeiteCerto.Image = Properties.Resources.certo_simbolo;
            pbLeite.Image = Properties.Resources.certo_simbolo;
            atributos5.contador += 1;
            pbLeite.Enabled = false;
        }

        private void pbSucoLaranja_Click(object sender, EventArgs e)
        {
            atributos5.sucoLaranja = true;
            pbSucoCerto.Image = Properties.Resources.certo_simbolo;
            pbSucoLaranja.Image = Properties.Resources.certo_simbolo;
            atributos5.contador += 1;
            pbSucoLaranja.Enabled = false;
        }

        private void pbBiscoito_Click(object sender, EventArgs e)
        {
            atributos5.biscoito = true;
            pbBiscoito.Image = Properties.Resources.certo_simbolo;
        }

        private void pbIogurte_Click(object sender, EventArgs e)
        {
            atributos5.iogurte = true;
            pbIogurte.Image = Properties.Resources.certo_simbolo;
        }

        private void pbGeleiaLaranja_Click(object sender, EventArgs e)
        {
            atributos5.geleiaLaranja = true;
            pbGeleiaLaranja.Image = Properties.Resources.certo_simbolo;
        }

        private void pbGeleiaCareja_Click(object sender, EventArgs e)
        {
            atributos5.geleiaCereja = true;
            pbGeleiaCareja.Image = Properties.Resources.certo_simbolo;
        }

        private void pbGeleiaMorango_Click(object sender, EventArgs e)
        {
            atributos5.geleiaMorango = true;
            pbGeleiaMorango.Image = Properties.Resources.certo_simbolo;
        }

        private void pbRefrigerente_Click(object sender, EventArgs e)
        {
            atributos5.refrigerante = true;
            pbRefrigerente.Image = Properties.Resources.certo_simbolo;
        }

        private void pbIogurteLimao_Click(object sender, EventArgs e)
        {
            atributos5.IogurteLimao = true;
            pbIogurteLimao.Image = Properties.Resources.certo_simbolo;
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase5.Play();
        }

    }
}

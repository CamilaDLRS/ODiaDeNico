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
    public partial class Fase1 : Form
    {
        Audios sons = new Audios();

        Banheiro atributos = new Banheiro();

        public Fase1()
        {
            InitializeComponent();
        }

        private void pbProximo_Click(object sender, EventArgs e)
        {
            if (atributos.escova == true && atributos.lapis == false && atributos.computador == false && atributos.livro == false)
            {
                sons.fase1_acertou.Play();
                MessageBox.Show("Parabéns você conseguiu selecionar os objetos.\n" +
                    "Agora vamos tomar o Café da Manhã.", "A caminho do Café da Manhã");

                
                Fase2 chamando = new Fase2();
                this.Hide();
                chamando.ShowDialog();
                this.Close();
            }

            else if (atributos.contador < 3 && pbEscova.Enabled == true)
            {
                sons.fase1_esqueceu.Play();
                MessageBox.Show("Parece que você esqueceu algum objeto. Continue procurando!");
            }

            else
            {
                sons.fase1_errou.Play();

                MessageBox.Show("Reveja os itens selecionados.", "Você se confundiu");
                atributos.escova = true;
                atributos.lapis = true;
                atributos.computador = true;
                atributos.livro = true;
                atributos.contador = 0;

                pbEscova.Enabled = true;
                pbLapis.Enabled = true;
                pbLivros.Enabled = true;
                pbComputador.Enabled = true;

                pbLapis.Image = Properties.Resources.lapis;
                pbLivros.Image = Properties.Resources.livros_icone_desenho;
                pbEscova.Image = Properties.Resources.escova1;
                pbComputador.Image = Properties.Resources.notebook;
            }
        }

        private void pbComputador_Click(object sender, EventArgs e)
        {
            pbComputador.Enabled = false;
            atributos.computador = false;
            pbComputador.Image = null;
            atributos.contador += 1;
        }

        private void pbLivros_Click(object sender, EventArgs e)
        {
            pbLivros.Enabled = false;
            atributos.livro = false;
            pbLivros.Image = null;
            atributos.contador += 1;
        }

        private void pbLapis_Click(object sender, EventArgs e)
        {
            pbLapis.Enabled = false;
            atributos.lapis = false;
            pbLapis.Image = null;
            atributos.contador += 1;
        }

        private void pbEscova_Click(object sender, EventArgs e)
        {
            pbEscova.Enabled = false;
            atributos.escova = false;
            pbEscova.Image = null;
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase1.Play();    
        }

        private void Fase1_Load(object sender, EventArgs e)
        {

        }
    }
}

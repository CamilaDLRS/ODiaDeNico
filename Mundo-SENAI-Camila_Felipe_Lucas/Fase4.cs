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
    public partial class Fase4 : Form
    {
        Audios sons = new Audios();

        Quadro quadro = new Quadro();
        public Fase4()
        {
            InitializeComponent();
        }

        private void Errou()
        {
            sons.fase4_errou.Play();

            MessageBox.Show("Parece que algum grupo do qual você \ninseriu o objeto não está certo." +
            "\n Por favor tente novamente.", "Tem algo de errado");
            pbLapis.Image = Properties.Resources.lapis12;
            pbPenal.Image = Properties.Resources.estojo;
            pbGuadaRoupa.Image = Properties.Resources.guardaroupa;
            pbRoupa.Image = Properties.Resources.roupa;
            pbRadio.Image = Properties.Resources.somM;
            pbCds.Image = Properties.Resources.cds;
            pbLata.Image = Properties.Resources.lata;
            pbLixo.Image = Properties.Resources.lixo;

            pbLata.Enabled = true;
            pbPenal.Enabled = true;
            pbGuadaRoupa.Enabled = true;
            pbRadio.Enabled = true;

            quadro.armario = false;
            quadro.estojo = false;
            quadro.lata = false;
            quadro.som = false;
            quadro.contador = 0;
        }   

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase4_lembrete.Play();
        }

        private void pbLata_Click(object sender, EventArgs e)
        {
            pbLata.Enabled = false;
            quadro.contador++;
                      
            if (quadro.contador == 3)
            {
                quadro.lata = true;
                pbLata.Image = Properties.Resources.lataV;
                pbLixo.Image = Properties.Resources.lixoV;
               
            }
            else
            {
                if (quadro.contador == 4)
                {
                    pbLixo.Image = Properties.Resources.lixoX;
                    pbLata.Image = Properties.Resources.lataX;
                    Errou();
                }
                else
                {
                    pbLixo.Image = Properties.Resources.lixoX;
                    pbLata.Image = Properties.Resources.lataX;
                }
            }

        }

        private void pbPenal_Click(object sender, EventArgs e)
        {
            pbPenal.Enabled = false;
            quadro.contador++;

            if (quadro.contador == 2)
            {
                quadro.estojo = true;
                pbPenal.Image = Properties.Resources.estojoV;
                pbLapis.Image = Properties.Resources.lapis3;
               
            }

            else if (quadro.contador == 4)
            {
                pbLapis.Image = Properties.Resources.lapisX;
                pbPenal.Image = Properties.Resources.estojoX;
                Errou();
            }

            else
            {
                pbLapis.Image = Properties.Resources.lapisX;
                pbPenal.Image = Properties.Resources.estojoX;
            }

        }

        private void pbGuadaRoupa_Click(object sender, EventArgs e)
        {
            pbGuadaRoupa.Enabled = false;
            quadro.contador++;

            if (quadro.contador == 4)
            {
                quadro.armario = true;
                pbGuadaRoupa.Image = Properties.Resources.guardaroupaV;
                pbRoupa.Image = Properties.Resources.roupaV;

                if (quadro.som == true && quadro.armario == true && quadro.estojo == true && quadro.lata == true)
                {
                    sons.fase4_acertou.Play();
                    MessageBox.Show("Parabéns você terminou seu exercício do colégio!!!\nAgora vamos ao" +
                        " mercado.", "A caminho do Mercado");

                    Fase5 proximo = new Fase5();
                    this.Hide();
                    proximo.ShowDialog();
                    this.Close();

                }
                else
                {
                    pbRoupa.Image = Properties.Resources.roupaX;
                    pbGuadaRoupa.Image = Properties.Resources.guardaroupaX;
                    Errou();
                }
            }
            else
            {
                pbRoupa.Image = Properties.Resources.roupaX;
                pbGuadaRoupa.Image = Properties.Resources.guardaroupaX;
            }
        }

        private void pbRadio_Click(object sender, EventArgs e)
        {
            pbRadio.Enabled = false;
            quadro.contador++;

            if (quadro.contador == 1)
            {
                quadro.som = true;
                pbRadio.Image = Properties.Resources.somV;
                pbCds.Image = Properties.Resources.cdsV;
            }
            else if (quadro.contador == 4)
            {
                pbCds.Image = Properties.Resources.cdsX;
                pbRadio.Image = Properties.Resources.somX;
                Errou();
            }

            else
            {
                pbCds.Image = Properties.Resources.cdsX;
                pbRadio.Image = Properties.Resources.somX;
            }
        }

        private void pbProximo_Click(object sender, EventArgs e)
        {
            sons.fase4_esqueceu.Play();
            MessageBox.Show("Termine o exercício.");
        }                  
    }
}


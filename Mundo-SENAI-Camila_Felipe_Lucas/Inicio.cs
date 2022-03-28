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
    public partial class Inicio : Form
    {
        Audios sons = new Audios();

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            sons.inico_fim.Stop();            
            Fase1 chamando = new Fase1();
            this.Hide();
            chamando.ShowDialog();
            this.Close();
           

        }

        private void lblCriadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse jogo foi criado com a intenção de ajudar pessoas com síndrome de Down no quesito organização e dia a dia, pois percebemos que eles tem certa dificuldade com isso. Criamos ele também para o Mundo SENAI, um evento que ocorre anualmente para apresentação dos cursos. Mostramos com esse jogo a lógica e o conhecimento de programação que ganhamos ao decorrer do nosso curso (Técnico em Informática).", "Apresentação", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void lblSENAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serviço Nacional de Aprendizagem Industrial", "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            sons.inico_fim.Stop();
            Tutorial chamando = new Tutorial();
            this.Hide();
            chamando.ShowDialog();
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            sons.inico_fim.Play();
        }
    }
}

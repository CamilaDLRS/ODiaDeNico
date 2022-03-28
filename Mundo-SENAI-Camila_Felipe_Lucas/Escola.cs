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
    public partial class Escola : Form
    {
        Audios sons = new Audios();

        public Escola()
        {
            InitializeComponent();
        }

        private void pbProximo_Click(object sender, EventArgs e)
        {
            Fase4 proximo = new Fase4();
            this.Hide();
            proximo.ShowDialog();
            this.Close();
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            sons.fase4.Play();
        }
    }
}

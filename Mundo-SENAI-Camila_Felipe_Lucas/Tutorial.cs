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
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = (@"Audio e videos\TUTORIA CORTADO.mp4");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            Inicio voltar = new Inicio();
            this.Hide();
            voltar.ShowDialog();
            this.Close();
        }

    }
}

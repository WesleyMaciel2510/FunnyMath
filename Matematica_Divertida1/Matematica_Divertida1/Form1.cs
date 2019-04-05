using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematica_Divertida1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela_Escolha1.BringToFront();
            adivinha.Visible = true;
            adivinha.BringToFront();
            binario.Visible = true;
            binario.BringToFront();
        }


        private void adivinha_Click(object sender, EventArgs e)
        {
            primeira_adivinhacao1.BringToFront();
            comecar.Visible = true;
            comecar.BringToFront();
        }

        private void comecar_Click(object sender, EventArgs e)
        {
            segunda_adivinhacao1.BringToFront();
        }

        private void binario_Click(object sender, EventArgs e)
        {
            primeira_busca1.BringToFront();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematica_Divertida1
{
    public partial class Primeira_adivinhacao : UserControl
    {
        public Primeira_adivinhacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Segunda_adivinhacao segunda_Adivinhacao = new Segunda_adivinhacao();
            segunda_Adivinhacao.BringToFront();

        }
    }
}

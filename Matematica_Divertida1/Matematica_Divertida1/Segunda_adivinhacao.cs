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
    public partial class Segunda_adivinhacao : UserControl
    {
        int i = 1;
        int qtde = 0;
        int[] c = new int[16] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31 };
        int contador = 0;
        int cont = 0;
        int x = 0;
        int quantidade = 1;
        Tela_Inicial tela_Inicial = new Tela_Inicial();

        public Segunda_adivinhacao()
        {
            InitializeComponent();

            label2.Text = c[0].ToString();
            label3.Text = c[1].ToString();
            label4.Text = c[2].ToString();
            label5.Text = c[3].ToString();
            label6.Text = c[4].ToString();
            label7.Text = c[5].ToString();
            label8.Text = c[6].ToString();
            label9.Text = c[7].ToString();
            label10.Text = c[8].ToString();
            label11.Text = c[9].ToString();
            label12.Text = c[10].ToString();
            label13.Text = c[11].ToString();
            label14.Text = c[12].ToString();
            label15.Text = c[13].ToString();
            label16.Text = c[14].ToString();
            label17.Text = c[15].ToString();

        }

        public void MudaNumero()
        {
            if (quantidade == 4)
            {
                cont = 8;
                for (int i = 0; i < c.Length; i++)
                {
                    cont++;

                    if (cont <= 8)
                    {

                        x = 0;
                    }
                    else if (cont >= 9 || cont <= 16)
                    {
                        x = 8;
                        if (cont == 16)
                        {
                            cont = 0;
                        }
                    }
                    c[i] = c[i] + x;
                }

                label2.Text = c[0].ToString();
                label3.Text = c[1].ToString();
                label4.Text = c[2].ToString();
                label5.Text = c[3].ToString();
                label6.Text = c[4].ToString();
                label7.Text = c[5].ToString();
                label8.Text = c[6].ToString();
                label9.Text = c[7].ToString();
                label10.Text = c[8].ToString();
                label11.Text = c[9].ToString();
                label12.Text = c[10].ToString();
                label13.Text = c[11].ToString();
                label14.Text = c[12].ToString();
                label15.Text = c[13].ToString();
                label16.Text = c[14].ToString();
                label17.Text = c[15].ToString();

                quantidade++;
            }

            if (quantidade == 3)
            {
                cont = 4;

                for (int i = 0; i < c.Length; i++)
                {
                    cont++;

                    if (cont <= 4)
                    {

                        x = 0;
                    }
                    else if (cont > 4 || cont <= 8)
                    {
                        x = 4;
                        if (cont == 8)
                        {
                            cont = 0;
                        }
                    }


                    c[i] = c[i] + x;


                }

                label2.Text = c[0].ToString();
                label3.Text = c[1].ToString();
                label4.Text = c[2].ToString();
                label5.Text = c[3].ToString();
                label6.Text = c[4].ToString();
                label7.Text = c[5].ToString();
                label8.Text = c[6].ToString();
                label9.Text = c[7].ToString();
                label10.Text = c[8].ToString();
                label11.Text = c[9].ToString();
                label12.Text = c[10].ToString();
                label13.Text = c[11].ToString();
                label14.Text = c[12].ToString();
                label15.Text = c[13].ToString();
                label16.Text = c[14].ToString();
                label17.Text = c[15].ToString();

                quantidade++;
            }

            

            

            if (quantidade == 2)
            {
                cont = 2;
                for (int i = 0; i < c.Length; i++)
                {
                    cont++;

                    if (cont < 3)
                    {

                        x = 0;
                    }
                    else if (cont == 3 || cont == 4)
                    {
                        x = 2;
                        if (cont == 4)
                        {
                            cont = 0;
                        }
                    }


                    c[i] = c[i] + x;
                }

                label2.Text = c[0].ToString();
                label3.Text = c[1].ToString();
                label4.Text = c[2].ToString();
                label5.Text = c[3].ToString();
                label6.Text = c[4].ToString();
                label7.Text = c[5].ToString();
                label8.Text = c[6].ToString();
                label9.Text = c[7].ToString();
                label10.Text = c[8].ToString();
                label11.Text = c[9].ToString();
                label12.Text = c[10].ToString();
                label13.Text = c[11].ToString();
                label14.Text = c[12].ToString();
                label15.Text = c[13].ToString();
                label16.Text = c[14].ToString();
                label17.Text = c[15].ToString();

                quantidade++;
            }

            if (quantidade == 1)
            {
                for (int i = 0; i < c.Length; i += 2)
                {
                    c[i] = c[i] + 1;
                }

                quantidade++;

                label2.Text = c[0].ToString();
                label3.Text = c[1].ToString();
                label4.Text = c[2].ToString();
                label5.Text = c[3].ToString();
                label6.Text = c[4].ToString();
                label7.Text = c[5].ToString();
                label8.Text = c[6].ToString();
                label9.Text = c[7].ToString();
                label10.Text = c[8].ToString();
                label11.Text = c[9].ToString();
                label12.Text = c[10].ToString();
                label13.Text = c[11].ToString();
                label14.Text = c[12].ToString();
                label15.Text = c[13].ToString();
                label16.Text = c[14].ToString();
                label17.Text = c[15].ToString();
            }





        }

        private void Sim_Click(object sender, EventArgs e)
        {
            qtde += i;
            i += i;

            MudaNumero();

            if (contador == 4 && qtde > 0)
            {
                MessageBox.Show("Seu número é " + qtde);
            }

            if (contador == 4 && qtde == 0)
            {
                MessageBox.Show("Você não pensou em nenhum número de 1 a 31. Tente novamente.");
            }

            contador++;
        }

        private void naao_Click(object sender, EventArgs e)
        {
            MudaNumero();
            

            if (contador == 4 && qtde > 0)
            {
                MessageBox.Show("Seu número é " + qtde);
            }

            if (contador == 4 && qtde == 0)
            {
                MessageBox.Show("Você não pensou em nenhum número de 1 a 31. Tente novamente.");
            }

            contador++;

        }
    }
}

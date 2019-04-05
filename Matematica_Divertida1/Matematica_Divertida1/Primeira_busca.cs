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
    public partial class Primeira_busca : UserControl
    {
        int[] vetor = new int[20];

        int resposta = 0;
        int palpite;
        int palpite_menor = 1;
        int palpite_maior = 20;
        int chance = 5;


        public Primeira_busca()
        {
            InitializeComponent();

            vetor[0] = 1;

            for (int i = 1; i < vetor.Length - 1; i ++)
            {
                vetor[i] = i + 1;
            }

            comboBox1.SelectedItem = "1";

            string texto = "BUSCA LINEAR é um tipo de pesquisa em vetores listas de modo sequencial, i. e., elemento por elemento de modo que a função do tempo em relação ao número de elementos é linear, ou seja, cresce proporcionalmente. \r" +
                "No melhor caso, o elemento a ser buscado é encontrado logo na primeira tentativa da busca. \r" +
                "No pior caso, o elemento a ser buscado encontra-se na última posição e são feitas N comparações, sendo N o número total de elementos. Num vetor ordenado, essa não é a pesquisa mais eficiente, a pesquisa (ou busca) binária, por exemplo, é um tipo de pesquisa com o gráfico de tempo logarítmo. ";
            textBox1.Text = texto.Replace("\r", Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            resposta = Convert.ToInt32(comboBox1.SelectedItem);

            label1.Text = "Digite seu palpite:";
            proximo.Visible = false;
            tentar.Visible = true;
            comboBox1.SelectedItem = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            palpite = Convert.ToInt32(comboBox1.SelectedItem);


            if (chance > 0)
            {
                if (palpite < palpite_menor || palpite > palpite_maior)
                {
                    label2.Left = 150;
                    label2.Text = ("Escolha um valor entre " + (palpite_menor+1) + " e " + (palpite_maior-1)+"!");
                }
                else
                {

                    if (palpite < resposta)
                    {
                        label2.Left = 70;
                        label2.Text = ("A resposta é maior que " + palpite + ". Tente novamente!");
                        palpite_menor = palpite;
                        chance--;
                    }

                    if (palpite > resposta)
                    {
                        label2.Text = ("A resposta é menor que " + palpite + ". Tente novamente!");
                        palpite_maior = palpite;
                        chance--;
                    }
                }
            }

            else
            {
                label2.Visible = false;
                comboBox1.Visible = false;
                pictureBox2.Visible = true;
                entenda.Visible = true;
                label1.Text = "Suas chances acabaram. A resposta é o número " + resposta + "!";
            }

            if (palpite == resposta)
            {
                pictureBox1.Visible = true;
                tentar.Visible = false;
                label2.Visible = false;
                comboBox1.Visible = false;
                entenda.Visible = true;
                label1.ForeColor = Color.Green;
                label1.Font = new Font("Segoe UI Semibold", 18, FontStyle.Bold);
                label1.Left = 100;
                label1.Text = "Parabéns. A resposta é o número " + resposta + "!";
            }
            
        }

        private void entenda_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = true;
            textBox1.BringToFront();
            entenda.Visible = false;
            proximo2.Visible = true;
        }

        private void proximo2_Click(object sender, EventArgs e)
        {
            string texto = "A BUSCA BINÁRIA é um eficiente algoritmo encontrar um item em uma lista ordenada de itens. \r" +
                "Ela funciona dividindo repetidamente pela metade a porção da lista que deve conter o item, até reduzir as localizações possíveis a apenas uma. Nós usamos a busca binária em um jogo de adivinhação no tutorial introdutório.";
            textBox1.Text = texto.Replace("\r", Environment.NewLine);
            proximo2.Visible = false;
            label3.Visible = true;
        }
    }
}

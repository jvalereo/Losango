using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AreaLosango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            /*Treinamento - Calcule a area do losango, tipo double*/
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis tipo double

            double D, d, area;


            //Declarando entrada de dado no textbox

            D = double.Parse(textBoxMaior.Text, CultureInfo.InvariantCulture);
            d = double.Parse(textBoxMenor.Text, CultureInfo.InvariantCulture);

            //Declarando a variavel area

            area = (D * d) / 2;

            //imprimir saida de dados no MessagemBox, concatenação

            MessageBox.Show("Valor da area = " + area.ToString("F2", CultureInfo.InvariantCulture)
                ,"Messagem",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Teste de novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo limpar textbox , focus

            textBoxMaior.Text = " ";
            textBoxMenor.Text = " ";
            textBoxMaior.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando codigo sair do programa

            Close();
        }

        //Fim do progama
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cobSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Declarando o codigo switch, treinamento com decisão 

            switch (cobSemana.Text)

            {
                case "Domingo":
                MessageBox.Show("Você escolheu o dia de Domingo, que é o 1º dia da Semana","Messeagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;


                case "Segunda - feira":
                MessageBox.Show("Você escolheu o dia Segunda-Feira, que é o 2º dia da Semana", "Messagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;

                case "Terça - feira":
                MessageBox.Show("Você escolheu o dia Terça-Feira, que é o 3º dia da Semana", "Messagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;

                case "Quarta - feira":
                MessageBox.Show("Você escolheu o dia Quarta-Feira, que é o 4º dia da Semana","Messagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;

                case "Quinta - feira":
                MessageBox.Show("Você escolheu o dia Quinta-Feira, que é o 5º dia da Semana", "Messagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;

                case "Sexta - feira":
                MessageBox.Show("Você escolheu o dia Sexta-Feira, que é o 6º dia da Semana", "Messagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;

                case "Sábado":
                MessageBox.Show("Você escolheu o dia Sábado, que é o 7º dia da Semanha", "Messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;


            }

            //Fim do programa

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo Fechar

            Close();
        }

       
    }
}

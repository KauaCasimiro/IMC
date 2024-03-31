using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float peso, altura, resultado;

            peso = float.Parse(pesoTB.Text);
            altura = float.Parse(alturaTB.Text);

            resultado = peso / (altura * altura);

            resulLB.Text = resultado.ToString("F");

            if (resultado < 16.9)
            {
                mensagemTB.Text = "Muito Abaixo do Peso";
            }
            else if (resultado >= 17 && resultado <= 18.4)
            {
                mensagemTB.Text = "Abaixo do Peso";
            }
            else if (resultado >= 18.5 && resultado <= 24.9)
            {
                mensagemTB.Text = "Peso Normal";
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                mensagemTB.Text = "Acima do peso";
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                mensagemTB.Text = "Obesidade grau I";
            }
            else if (resultado >= 35 && resultado <= 40)
            {
                mensagemTB.Text = "Obesidade grau II";
            }
            else
            {
                mensagemTB.Text = "Obesidade grau III";
            }

        }

        private void Peso_Click(object sender, EventArgs e)
        {

        }

        private void peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}

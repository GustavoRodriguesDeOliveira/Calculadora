using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Calculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
             model = new ModelCalculadora();
        }//fim do construtor

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = model.Somar(num1, num2);
                Resultado.Text = "" + result;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim da soma

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = model.Dividir(num1, num2);
            Resultado.Text = "" + result;
            if(result == -1)
            {
                Resultado.Text = "Impossível dividir por zero!";
            }
            else
            {
                Resultado.Text = "" + result;
            }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim da divisão

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim dó primero numero

        private void subitrair_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = model.Subitrair(num1, num2);
            Resultado.Text = "" + result;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim da subitrasão

        private void divisao_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = model.Dividir(num1, num2);
            Resultado.Text = "" + result;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim da divisão

        private void vezes_Click(object sender, EventArgs e)
        {
            try
            {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = model.Multiplicar(num1, num2);
            Resultado.Text = "" + result;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do vezes

        private void raiz_Click(object sender, EventArgs e)
        {
            try
            {

            double num1 = Convert.ToDouble(textBox1.Text);
            double result = model.Raiz(num1);
            if (result == -1)
            {
                Resultado.Text = "Impossivel calcular a raiz!";
            }
            else
            {
                Resultado.Text = "" + result;
            }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim da raiz

        private void potencia_Click(object sender, EventArgs e)
        {
            try
            {

            double bas = Convert.ToDouble(textBox1.Text);
            double expoente = Convert.ToDouble(textBox2.Text);
            double result = model.Potencia(bas, expoente);
            Resultado.Text = "" + result;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim da potencia
        private void Resultado_Click(object sender, EventArgs e)
        {

        }//fim do resultado

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim do segundo numero


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de numeros 2


        private void label1_Click(object sender, EventArgs e)
        {

        }//fim do primeiro numero
    }//fim da classe
}//fim do projeto

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceitos_Basicos
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string name = "Thiago";
            //MessageBox.Show("Olá " + name);

            //double saldo = 100.0;
            //double valorDoSaque = - 1;

            //bool saqueAutorizado = (saldo >= valorDoSaque) && (valorDoSaque > 0);

            //if (saqueAutorizado)
            //{
            //    saldo -= valorDoSaque;
            //    MessageBox.Show($"Saldo atual: {saldo}");
            //}
            //else {
            //    MessageBox.Show($"Valor de saque não autorizado: {saldo}");
            //};

            //double saldo = 500.0;
            //if (saldo < 0.0)
            //{
            //    MessageBox.Show("Você está no negativo!");
            //} else if (saldo < 1000000.0) {
            //    MessageBox.Show("Você é um bom cliente");
            //}
            //else {
            //    MessageBox.Show("Você é milionário!");
            //};

            //byte idade = 16;
            //bool brasileira= true;
            //bool verificaAptidao = (idade >= 18) && (brasileira == true);
            //if (verificaAptidao)
            //{
            //    MessageBox.Show("Você está apto a votar, parabéns!");
            //}
            //else {
            //    MessageBox.Show("Sem aptidão para você votar nessa momento.");
            //};

            //MessageBox.Show("O saldo da conta após o saque é: " + saldo );

            //int a = 1, b = -3, c = 2;
            //double delta, x1, x2;

            //delta = (b * b) - (4 * a * c);

            //if (delta < 0)
            //{
            //    MessageBox.Show("Não existe raízes reais.");
            //}
            //else {
            //    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            //    MessageBox.Show($"As raízes da equação: x1 = {x1} e x2 ={x2}");
            //}

            //decimal valorDaNotaFiscal = 7000.0m;
            //decimal valorImposto;

            //if (valorDaNotaFiscal <= 999.0m)
            //{
            //    valorImposto = 0.02m;
            //}
            //else if (valorDaNotaFiscal <= 2999.0m)
            //{
            //    valorImposto = 0.025m;
            //}
            //else if (valorDaNotaFiscal <= 6999.0m)
            //{
            //    valorImposto = 0.028m;
            //}
            //else
            //{
            //    valorImposto = 0.03m;
            //}

            //MessageBox.Show($"Alíquota do imposto: {valorImposto:P}");

            int valor = 9;
            
            string mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";
            MessageBox.Show(mensagem);
        }
    }
}

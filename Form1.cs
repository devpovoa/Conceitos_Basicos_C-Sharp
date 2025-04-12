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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Assuntos avançados
            ContaDTO contaDTO1 = new ContaDTO
            {
                NumeroConta = 1,
                SaldoConta = 0,
                TitularConta = new ClienteDTO
                {
                    Nome = "Thiago Povoa",
                    Cpf = "123.456.789 - 10",
                    Rg = "RJ501",
                    Endereco = "Rua do Código"
                }

            };

            ContaDTO contaDTO2 = new ContaDTO
            {
                NumeroConta = 1,
                SaldoConta = 1000.0m,
                TitularConta = new ClienteDTO
                {
                    Nome = "Daiana Povoa",
                    Cpf = "123.456.789 - 10",
                    Rg = "RJ501",
                    Endereco = "Rua do Código"
                }

            };

            Conta c1 = ContaMapper.ConverterParaEntidade(contaDTO1);
            Conta c2 = ContaMapper.ConverterParaEntidade(contaDTO2);

            bool situacaoDoSaque = c2.Sacar(200);

            if (situacaoDoSaque)
            {
                c1.Depositar(200);
            }

            string message = 
                 $"Títular: {c1.TitularConta.Nome}\n" +
                 $"Saldo da conta: {c1.SaldoConta:F2}\n" +
                 $"Número da Conta: {c1.NumeroConta}\n" +
                 $"Situação do saque: {situacaoDoSaque}\n\n" +
                 $"Títular: {c2.TitularConta.Nome}\n" +
                 $"Número da Conta: {c2.NumeroConta}\n" +
                 $"Saldo da conta: {c2.SaldoConta:F2}\n" +
                 $"Situação da Operação: {situacaoDoSaque}";

            if (situacaoDoSaque)
            {
                MessageBox.Show($"Transferência realizada com sucesso!\n\n{message}");
            }
            else
            {
                MessageBox.Show("Impossível realizar transação.");
            }

            /**
             * @autor : DevPovoa
             * @description: Conceitos básicos da linguagem C-Sharp
             */

            // 1 Seção
            string name = "Thiago";
            MessageBox.Show("Olá " + name);


            // 2 Seção
            double saldo = 100.0;
            double valorDoSaque = -1;
            bool saqueAutorizado = (saldo >= valorDoSaque) && (valorDoSaque > 0);
            if (saqueAutorizado)
            {
                saldo -= valorDoSaque;
                MessageBox.Show($"Saldo atual: {saldo}");
            }
            else
            {
                MessageBox.Show($"Valor de saque não autorizado: {saldo}");
            }
            ;

            // 3 Seção
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
            ;

            // 4 Seção
            byte idade = 16;
            bool brasileira = true;
            bool verificaAptidao = (idade >= 18) && (brasileira == true);
            if (verificaAptidao)
            {
                MessageBox.Show("Você está apto a votar, parabéns!");
            }
            else
            {
                MessageBox.Show("Sem aptidão para você votar nessa momento.");
            }
            ;
            MessageBox.Show("O saldo da conta após o saque é: " + saldo);


            // 5 Seção
            int a = 1, b = -3, c = 2;
            double delta, x1, x2;

            delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                MessageBox.Show("Não existe raízes reais.");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show($"As raízes da equação: x1 = {x1} e x2 ={x2}");
            }

            // 6 Seção
            decimal valorDaNotaFiscal = 7000.0m;
            decimal valorImposto;

            if (valorDaNotaFiscal <= 999.0m)
            {
                valorImposto = 0.02m;
            }
            else if (valorDaNotaFiscal <= 2999.0m)
            {
                valorImposto = 0.025m;
            }
            else if (valorDaNotaFiscal <= 6999.0m)
            {
                valorImposto = 0.028m;
            }
            else
            {
                valorImposto = 0.03m;
            }

            MessageBox.Show($"Alíquota do imposto: {valorImposto:P}");


            // 7 Seção
            int valor = 9;

            string mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";
            MessageBox.Show(mensagem);

            decimal valorInvestido = 1000.0m;
            int count = 0;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.01m;
                count = i;
            }
            ;

            while (count < 12)
            {
                valorInvestido *= 1.01m;
                count++;
            }

            do
            {
                valorInvestido *= 1.01m;
                count++;
            }
            while (count < 12);
            MessageBox.Show($"Valor investido ao final de: {count} meses é R$ {valorInvestido:F2}");


            // 8 Seção
            int numero = 100;
            int total = 0;
            for (int i = 2; i <= numero; i += 2) total += i;

            MessageBox.Show($"Soma geral dois números multiplos de 2: {total}");

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                    MessageBox.Show($"Número divisível por 3: {i}");

                if (i % 4 == 0)
                    MessageBox.Show($"Número divisível por 4: {i}");
            }


            // 9 Seção
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                MessageBox.Show($"O fatorial de {n} é: {fatorial:N0}");
            }


            //10 Seção
            int a = 0;
            int b = 1;

            string sequencia = $"Fibonacci: {a}, {b}";

            for (int i = 2; i < 10; i++)
            {
                int proximo = a + b;
                sequencia += $", {proximo}";
                a = b;
                b = proximo;
            }

            MessageBox.Show(sequencia);



            // For encadeados 
            string resultado = "";

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    resultado += $"{i * j} ";
                }
                resultado += "\n";
            }
            MessageBox.Show(resultado);


        }
    }
}

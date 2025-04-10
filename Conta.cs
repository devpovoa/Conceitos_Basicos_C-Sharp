﻿namespace Conceitos_Basicos
{
    internal class Conta
    {
        public int NumeroConta { get;  private set; }
        public Cliente TitularConta { get; private set; }
        public decimal SaldoConta { get; private set; }

        public Conta(int numeroConta, string nome)
        {
            this.NumeroConta = numeroConta;
            this.TitularConta = new Cliente(nome);
            this.SaldoConta = 0;
        }

        public Conta(int numeroConta, string nome, string cpf, string rg, string endereco)
        {
            this.NumeroConta = numeroConta;
            this.TitularConta = new Cliente(nome, cpf, rg, endereco);
            this.SaldoConta = 0;
        }


        //public void SacarValor(decimal valor) {
        //    if (this.saldoConta >= valor)
        //    {
        //        this.saldoConta -= valor;
        //    }

        //}
        //public void NumConta(int numConta)
        //{
        //   this.NumeroConta = numConta;
        //}


        public bool Sacar(decimal valor)
        {
            if (this.SaldoConta >= valor)
            {
                this.SaldoConta -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                this.SaldoConta += valor;
            }
        }

        public void Transfere(decimal valor, Conta destino)
        {
            if (this.Sacar(valor))
            {
                destino.Depositar(valor);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Endereco { get; private set; }


        public Cliente(string nome, string cpf, string rg, string endereco)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Endereco = endereco;
        }


        public void AtualizarEndereco(string novoEndereco)
        {
            this.Endereco = novoEndereco;
        }
        
    }
}

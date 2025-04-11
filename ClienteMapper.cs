using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    internal static class ClienteMapper
    {
        public static Cliente ConverterParaEntidade(ClienteDTO dTO)
        {
            return new Cliente(dTO.Nome, dTO.Cpf, dTO.Rg, dTO.Endereco);
        }
    }
}

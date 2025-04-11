using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    internal static class ContaMapper
    {
        public static Conta ConverterParaEntidade (ContaDTO dTO)
        {
            Cliente cliente = ClienteMapper.ConverterParaEntidade(dTO.TitularConta);
            return new Conta(dTO.NumeroConta, cliente, dTO.SaldoConta);
        }
    }
}

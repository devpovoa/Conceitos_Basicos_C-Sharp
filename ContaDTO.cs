using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    internal class ContaDTO
    {
        public int NumeroConta { get; set; }
        public ClienteDTO TitularConta { get; set; }
        public decimal SaldoConta { get; set; }

    }
}

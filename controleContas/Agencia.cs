using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    internal class Agencia
    {
        public int NumeroAgencia { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public Banco BancoVinculado { get; set; }
    }
}

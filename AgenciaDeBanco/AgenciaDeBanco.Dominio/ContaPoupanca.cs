using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeBanco.Dominio
{
    public class ContaPoupanca : Conta
    {

        public decimal Rendimento { get; private set; }
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            Rendimento = 0.004M;
        }
    }
}

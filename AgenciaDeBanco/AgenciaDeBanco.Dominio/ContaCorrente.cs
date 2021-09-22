using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeBanco.Dominio
{
    public class ContaCorrente : Conta
    {
        public decimal TaxaManutencao { get; private set; }
        public ContaCorrente(Cliente cliente, decimal limite) : base(cliente)
        {
            TaxaManutencao = 0.05M;
            Limite = limite;
        }

        public decimal Limite { get; private set; }

        public override void Sacar(decimal valor, string senha)
        {
            if (Senha != senha) throw new Exception("Senha inválida!!");
            if (Saldo + Limite < valor) throw new Exception("Saldo insuficiente!!");
            Saldo -= valor;
        }
    }
}

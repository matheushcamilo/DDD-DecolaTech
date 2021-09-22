using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeBanco.Dominio
{
    public class Conta
    {
        //init é um set que funciona apenas na inicialização do objeto
        public int NumeroConta { get; init; }

        public int DigitoVerificador { get; init; }

        public decimal Saldo { get; protected set; }

        //A interrogação em DateTime indica que, excepcionalmente para este caso, DateTime pode receber null
        public DateTime? DataAbertura { get; private set; }

        public DateTime? DataEncerramento { get; private set; }

        public SituacaoConta Situacao { get; private set; }

        public string Senha { get; private set; }

        public Cliente Cliente { get; init; }

        public Conta(Cliente cliente)
        {
            Cliente = cliente ?? throw new Exception("Cliente deve ser informado");
            Random random = new Random();
            NumeroConta = random.Next(50000, 100000);
            Situacao = SituacaoConta.Criada;
        }
    }
}

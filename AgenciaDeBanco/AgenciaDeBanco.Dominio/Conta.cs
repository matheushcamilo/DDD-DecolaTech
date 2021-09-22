using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaDeBanco.Dominio
{
    public abstract class Conta
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
         public string ValidaStringVazia(string str)
        {
            if (string.IsNullOrEmpty(str)) throw new Exception("String vazia");
            return str;
        }
        public void Abrir(string senha)
        {
            SetaSenha(senha);
            Situacao = SituacaoConta.Aberta;
            DataAbertura = DateTime.Now;
        }

        public void SetaSenha(string senha)
        {
            senha = ValidaStringVazia(senha);
            //Método de validação de formato de string do pacote RegularExpressions
            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                throw new Exception("Senha inválida!!");
            }
        }

        public virtual void Sacar(decimal valor, string senha)
        {
            if (Senha != senha) throw new Exception("Senha inválida!!");
            if (Saldo < valor) throw new Exception("Saldo insuficiente!!");
            Saldo -= valor;
        }
    }
}

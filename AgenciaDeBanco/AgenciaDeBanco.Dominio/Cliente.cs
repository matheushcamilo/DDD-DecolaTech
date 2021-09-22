using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeBanco.Dominio
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public string cpf { get; private set; }

        public string RG { get; private set; }

        public Endereco Endereco { get; private set; }
        public Cliente(string nome, string cpf, string rG, Endereco endereco)
        {
            Nome = string.IsNullOrWhiteSpace(nome) == true ? throw new Exception("Nome inválido") : nome;
            this.cpf = cpf.Length != 11 ? throw new Exception("CPF inválido") : cpf;
            RG = rG.Length != 7 ? throw new Exception("RG inválido") : rG;
            Endereco = endereco ?? throw new Exception("Endereço deve ser informado");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeBanco.Dominio
{
    public class Endereco
    {
        public string Logradouro { get; private set; }

        public string CEP { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }
        public Endereco(string logradouro, string cEP, string cidade, string estado)
        {
            Logradouro = string.IsNullOrWhiteSpace(logradouro) ? throw new Exception("Endereço inválido") : logradouro;
            CEP = cEP.Length != 8 ? throw new Exception("CEP inválido") : cEP;
            Cidade = string.IsNullOrWhiteSpace(cidade) ? throw new Exception("Cidade inválido") : cidade;
            Estado = string.IsNullOrWhiteSpace(estado) ? throw new Exception("Estado inválido") : estado;
        }
    }
}

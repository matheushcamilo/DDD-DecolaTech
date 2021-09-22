using AgenciaDeBanco.Dominio;
using System;

namespace AgenciaDeBancoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua de" +
                    " casa", "15161318", "Recife", "Pernambuco");
                Cliente cliente = new Cliente("Matheus Henrique", "05123456789", "0215448", endereco);

                Conta conta = new Conta(cliente);
                Console.WriteLine("Conta criada: " + conta.NumeroConta + " -> " + conta.DigitoVerificador);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

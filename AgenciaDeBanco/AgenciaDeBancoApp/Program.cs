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
                //Conta é uma classe abstrata e não pode ser instanciada
                Conta conta = new ContaCorrente(cliente);
                Console.WriteLine("Conta criada: " + conta.NumeroConta + " -> " + conta.DigitoVerificador);

                conta.Abrir("123adb78919");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

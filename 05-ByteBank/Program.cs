using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora";
            gabriela.cpf = "123.456.789.10";

            conta.titular = gabriela;
            conta.numero = 123;
            conta.agencia = 123456;
            conta.saldo = 500;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(gabriela.nome);

            Console.ReadLine();

        }
    }
}

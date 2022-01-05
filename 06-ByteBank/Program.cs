using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = new Cliente();
            
            conta.Titular.Nome = "Bruno";
            conta.Titular.CPF = "123.456.789.10";
            conta.Titular.Profissao = "Desenvolvedor";

            conta.Numero = 123;
            conta.Agencia = 123456;
            conta.Saldo = 250;

            Console.WriteLine("Nome: " + conta.Titular.Nome);
            Console.WriteLine("CPF: " + conta.Titular.CPF);
            Console.WriteLine("Profissao: " + conta.Titular.Profissao);
            Console.WriteLine("N° da conta: " + conta.Numero);
            Console.WriteLine("N° da agência: " + conta.Agencia);
            Console.WriteLine("Saldo: " + conta.Saldo);

            Console.ReadLine();
        }
    }
}

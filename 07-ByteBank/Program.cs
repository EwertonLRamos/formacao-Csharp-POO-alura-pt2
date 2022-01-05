using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(123, 123456);
            ContaCorrente conta2 = new ContaCorrente(456, 456789);

            Console.WriteLine("Qtd de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}

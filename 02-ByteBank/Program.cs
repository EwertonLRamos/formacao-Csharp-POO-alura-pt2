using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Titular: " + contaGabriela.titular);
            Console.WriteLine("Titular: " + contaGabriela.numero);

            Console.ReadLine();
        }
    }
}

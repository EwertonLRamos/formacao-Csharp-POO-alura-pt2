using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDoDouglas = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(200);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Transferir(100, contaDoDouglas);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaDoDouglas.saldo);
            
            Console.ReadLine();
        }
    }
}

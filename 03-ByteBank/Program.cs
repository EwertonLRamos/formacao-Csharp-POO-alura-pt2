using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabrielaAndrade = new ContaCorrente();

            contaGabrielaAndrade.titular = "Gabriela";
            contaGabrielaAndrade.agencia = 863;
            contaGabrielaAndrade.numero = 863452;
            contaGabrielaAndrade.saldo = 100;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();

            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863452;
            contaGabrielaCosta.saldo = 100;

            Console.WriteLine(contaGabrielaCosta == contaGabrielaAndrade);

            contaGabrielaAndrade = contaGabrielaCosta;

            Console.WriteLine(contaGabrielaCosta == contaGabrielaAndrade);

            Console.ReadLine();
        }
    }
}

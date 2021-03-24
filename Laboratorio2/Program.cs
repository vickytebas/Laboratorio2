using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaBob = new Conta(false, 123456, "Bob Nelson", 0f);

            Conta contaTestolfo = new Conta(true, 717171, "Testolfo Rocha", 0f);

            Conta contaLisa = new Conta(false, 654321, "Lisa Leite", 0f);

            contaBob.DepositarDinheiro(5000f);

            contaLisa.DepositarDinheiro(2000f);

            contaTestolfo.DepositarDinheiro(1500f);

            contaBob.TransferirDinheiro(600f, contaTestolfo);

            contaLisa.SacarDinheiro(250);

            contaLisa.TransferirDinheiro(400, contaTestolfo);

            contaTestolfo.TransferirDinheiro(1000, contaBob);

            contaBob.SacarDinheiro(900);

            contaBob.TransferirDinheiro(1500, contaLisa);

            contaTestolfo.TransferirDinheiro(1200, contaLisa);

            contaBob.SacarDinheiro(2000);

            contaLisa.DepositarDinheiro(100);

            contaTestolfo.TransferirDinheiro(700, contaBob);

            Console.WriteLine("Total conta Bob: {0}, conta Testolfo: {1}, conta Lisa: {2}", contaBob.SaldoAtual, contaTestolfo.SaldoAtual, contaLisa.SaldoAtual);
            Console.ReadLine();
        }
    }
}

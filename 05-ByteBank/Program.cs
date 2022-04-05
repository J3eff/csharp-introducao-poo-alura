using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.agencia = 563;
            conta.numero = 5634527;
            conta.saldo = 500;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();
        }
    }
}

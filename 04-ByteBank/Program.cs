using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine("ANTES DO SAQUE: " + contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine();

            Console.WriteLine("DEPOIS DO SAQUE: " + contaDoBruno.saldo);
            Console.WriteLine("Resultado saque? " + resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine();

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("SALDO CONTA BRUNO: " + contaDoBruno.saldo);
            Console.WriteLine("SALDO CONTA GABRIELA: " + contaDaGabriela.saldo);
            Console.WriteLine();

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("SALDO CONTA BRUNO: " + contaDoBruno.saldo);
            Console.WriteLine("SALDO CONTA GABRIELA: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado transferencia? " + resultadoTransferencia);
            Console.WriteLine();

            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("SALDO CONTA BRUNO: " + contaDoBruno.saldo);
            Console.WriteLine("SALDO CONTA GABRIELA: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}

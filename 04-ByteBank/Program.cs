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

            Console.WriteLine("DEPOIS DO SAQUE: " + contaDoBruno.saldo);
            Console.WriteLine("Houve o saque? " + (resultadoSaque ? "SIM" : "NÃO"));

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            

            Console.ReadLine();
        }
    }
}

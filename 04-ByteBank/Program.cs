﻿using System;
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
            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine("DEPOIS DO SAQUE: " + contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            Console.ReadLine();
        }
    }
}
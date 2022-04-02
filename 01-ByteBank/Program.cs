using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente(); //Instancia

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine($"Titular: {contaDaGabriela.titular}, Agencia: {contaDaGabriela.agencia}, Numero: {contaDaGabriela.numero}, Saldo: R${contaDaGabriela.saldo}");

            contaDaGabriela.saldo += 200;

            Console.WriteLine($"Saldo atualizado: R${contaDaGabriela.saldo}");

            Console.ReadLine();
        }
    }
}

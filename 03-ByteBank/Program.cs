using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo referencia -> As variaveis de referencia guardam o endereço daquele objeto (são guardadas na memoria).
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;
                        
            Console.WriteLine("Igualdade de tipo referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            //Tipo valor - Guarda valores
            int idade = 27;
            int idadeMaisUmVez = 27;
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmVez));

            // As duas variaveis passam a aponas para mesmo lugar na memoria
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;

            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}

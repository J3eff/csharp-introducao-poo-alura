using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100;


        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
                return false;

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente constaDestino)
        {
            if (this.saldo < valor)
                return false;

            this.saldo -= valor;
            constaDestino.Depositar(valor);
            return true;
        }
    }
}


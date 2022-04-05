
namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
                return; //Para de executar o método, e devolve o fluxo do programa.

            this.saldo = saldo;
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
                return false;

            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente constaDestino)
        {
            if (saldo < valor)
                return false;

            saldo -= valor;
            constaDestino.Depositar(valor);
            return true;
        }
    }
}



namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo
        {
            get { return _saldo; }

            set
            {
                if (value < 0)
                    return; //Para de executar o método, e devolve o fluxo do programa.

                _saldo = value;
            }
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente constaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            constaDestino.Depositar(valor);
            return true;
        }
    }
}


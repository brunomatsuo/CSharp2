using System;
//using _05_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente. Saque não realizado.");
                return false;
            }
            else
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente. Transferência não realizada.");
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine("Transferência realizada com sucesso.");
                return true;
            }
        }
    }
}

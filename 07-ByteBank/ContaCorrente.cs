using System;
//using _05_ByteBank;


namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private int _agencia;
        private int _numero;

        public static int TotalDeContasCriadas { get; private set; }
  
        public Cliente Titular { get; set; }
        public int Agencia {
            get
            {
                return _agencia;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero {
            get
            {
                return _numero;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _numero = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

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

using System;

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            Console.WriteLine("Saldo insuficiente. Saque não realizado.");
            return false;
        }
        else
        {
            this.saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            Console.WriteLine("Saldo insuficiente. Transferência não realizada.");
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine("Transferência realizada com sucesso.");
            return true;
        }
    }
}
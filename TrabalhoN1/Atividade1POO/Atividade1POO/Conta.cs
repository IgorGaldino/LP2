using System;

namespace Atividade1POO
{
    public abstract class Conta
    {

        private string titular = string.Empty;

        public Conta(string t)
        {
            Titular = t;
        }

        public abstract int Id { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public virtual void depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void sacar(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
        }

    }
}

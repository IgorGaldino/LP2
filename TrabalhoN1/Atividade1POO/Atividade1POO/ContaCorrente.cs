using System;

namespace Atividade1POO
{
    public class ContaCorrente : Conta
    {
        public const double TAXA = 0.10;
        public string titular = string.Empty;

        public ContaCorrente(string t) : base(t) { }

        public override int Id { get; set; }

        public override void depositar(double valor)
        {
            Saldo += valor - valor * TAXA;
        }

        public override void sacar(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor - valor * TAXA;
        }
    }
}
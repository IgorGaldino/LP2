using System;
using System.ComponentModel.DataAnnotations;

namespace Atividade2EFCore
{
    public class ContaCorrente
    {
        public const double TAXA = 0.10;
        public string titular = string.Empty;

        public ContaCorrente(){}
        public ContaCorrente(string t)
        {
            this.titular = t;
        }

        //[Key]
        public int Id { get; set; }
        public double Saldo { get; set; }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public void depositar(double valor)
        {
            Saldo += valor - valor * TAXA;
        }

        public void sacar(double valor)
        {
            if(valor <= Saldo)
                Saldo -= valor - valor * TAXA;
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Atividade2EFCore
{
    public class ContaPoupanca
    {

        private double taxaJuros;
        private DateTime dataAniversario;
        private string titular = string.Empty;

        public ContaPoupanca() {}

        public ContaPoupanca(double j, DateTime d, string t)
        {
            this.titular = t;
            taxaJuros = j;
            dataAniversario = d;
        }

        //[Key]
        public int Id { get; set; }
        public double Juros { get; set; }
        public DateTime DataAniversario { get; set; }
        public double Saldo { get; set; }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public void depositar(double valor)
        {
            Saldo += valor;
        }

        public void sacar(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
        }

        public void addRendimento()
        {
            if (DateTime.Now.Equals(dataAniversario))
            {
                double rendimento = Saldo * taxaJuros;
                depositar(rendimento);
            }
        }
    }
}

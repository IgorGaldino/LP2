using System;

namespace Atividade1POO
{
    public class ContaPoupanca : Conta
    {

        private double taxaJuros;
        private DateTime dataAniversario;
        private string titular = string.Empty;

        public ContaPoupanca(double j, DateTime d, string t) : base(t)
        {
            taxaJuros = j;
            dataAniversario = d;
        }

        public override int Id { get; set; }
        public double Juros { get; set; }
        public DateTime DataAniversario { get; set; }

        public override void depositar(double valor)
        {
            Saldo += valor;
        }

        public override void sacar(double valor)
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

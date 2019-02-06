using System;
using System.ComponentModel.DataAnnotations;

namespace Atividade2EFCore
{
    public class ContaPoupanca
    {

        public ContaPoupanca() {}

        public ContaPoupanca(double j, DateTime d, string t, Agencia a)
        {
			Agencia = a;
            Titular = t;
            Juros = j;
            DataAniversario = d;
        }

        public int Id { get; set; }
        public double Juros { get; set; }
        public DateTime DataAniversario { get; set; }
        public double Saldo { get; set; }
        public string Titular { get; set; }

		public int AgenciaId { get; set; }
		public Agencia Agencia { get; set; }

        public void addRendimento()
        {
            if (DateTime.Now.Equals(DataAniversario))
            {
                double rendimento = Saldo * Juros;
				Saldo += rendimento;
            }
        }
    }
}

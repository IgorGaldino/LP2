using System;
using System.ComponentModel.DataAnnotations;

namespace Atividade2EFCore
{
    public class ContaCorrente
    {
        public const double TAXA = 0.10;

        public ContaCorrente(){}
        public ContaCorrente(string t, Agencia a)
        {
			Agencia = a;
            Titular = t;
        }

        public int Id { get; set; }
        public double Saldo { get; set; }
        public string Titular{ get; set; }

		public int AgenciaId { get; set; }
		public Agencia Agencia { get; set; }

    }
}

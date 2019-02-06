using System;
using System.Collections.Generic;
using System.Linq;
using Atividade2EFCore.Model;

namespace Atividade2EFCore
{
    public class Agencia
    {
		public Agencia()
		{
			ContasCorrente = new List<ContaCorrente>();
			ContasPoupanca = new List<ContaPoupanca>();
			Solicitacoes = new List<Solicitacao>();
		}

        public int Id { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }


		public List<ContaCorrente> ContasCorrente { get; set; }
        public List<ContaPoupanca> ContasPoupanca { get; set; }
        public List<Solicitacao> Solicitacoes { get; set; }
		/*
        public void addCCorrente(ContaCorrente cc)
        {
            contasCorrente.Add(cc);
            Console.WriteLine("Número da conta corrente " + cc.Id + " de titular " + cc.Titular + " criada com sucesso!");
        }

        public void addCPoupanca(ContaPoupanca cp)
        {
            contasPoupanca.Add(cp);
            Console.WriteLine("Número da conta poupança " + cp.Id + " de titular " + cp.Titular + " criada com sucesso!");
        }*/

        public ContaCorrente findOneCCorrente(int num)
        {
			using (var db = new StoreContext())
			{
				try
				{
					var cCorrente = db.ContasCorrente
					.Single(c => c.Id == num);
					return cCorrente;
				}
				catch (Exception)
				{
					return null;
				}
			}
        }

		public void findAllCCorrente()
		{
			using (var db = new StoreContext())
			{
				try
				{
					var contas = db.Set<ContaCorrente>();
					Console.WriteLine("\nContas Correntes\n");
					foreach (var cc in contas)
					{
						Console.WriteLine("Número da conta: " + cc.Id + " Titular " + cc.Titular);
					}
					Console.WriteLine("");
				}
				catch (Exception)
				{
					Console.WriteLine("Nenhuma conta corrente cadastrada");
				}
			}
		}

		public ContaPoupanca findOneCPoupanca(int num)
        {
			using (var db = new StoreContext())
			{
				try
				{
					var cPoupanca = db.ContasPoupanca
					.Single(cp => cp.Id == num);
					return cPoupanca;
				}
				catch (Exception)
				{
					return null;
				}
			}
		}

		public void findAllCPoupanca()
		{
			using (var db = new StoreContext())
			{
				try
				{
					var contas = db.Set<ContaPoupanca>();
					Console.WriteLine("\nContas Poupança\n");
					foreach (var cp in contas)
					{
						Console.WriteLine("Número da conta: " + cp.Id + " Titular " + cp.Titular);
					}
					Console.WriteLine("");
				}
				catch (Exception)
				{
					Console.WriteLine("Nenhuma conta poupança cadastrada");
				}
			}
		}
	}
}

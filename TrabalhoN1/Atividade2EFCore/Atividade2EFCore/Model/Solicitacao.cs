using System;
using System.Linq;
using Atividade2EFCore.Model;

namespace Atividade2EFCore
{
    public class Solicitacao
    {
        public int Id { get; set; }
		public int AgenciaId { get; set; }
		public Agencia Agencia { get; set; }

		public void realizarSolicitacao(Banco banco)
		{
			using (var db = new StoreContext())
			{
				banco.findAllAgencia();
				Console.WriteLine("Informe o Id da agência: ");
				Agencia agencia = banco.findAgencia(int.Parse(Console.ReadLine()));

				if (agencia == null)
				{
					Console.WriteLine("Agência não existe!\n");
					return;
				}

				Console.WriteLine(
					"Informe o tipo da conta:\n" +
					"1 - Corrente | 2 - Poupança");

				int tipoConta = int.Parse(Console.ReadLine());

				if (tipoConta == 1)
				{
					agencia.findAllCCorrente();

					Console.WriteLine("Informe o numero da conta: ");
					int numConta = int.Parse(Console.ReadLine());
					try
					{
						var cc = db.Set<ContaCorrente>().First(p => p.Id == numConta);	//Update Conta Corrente in banco

						Console.WriteLine(
							"1 - Consultar Saldo\n" +
							"2 - Sacar\n" +
							"3 -  Depositar");
						int op = int.Parse(Console.ReadLine());

						if (op == 1)
						{
							Console.WriteLine(
							"Conta: " + cc.Id +
							"\nTitular: " + cc.Titular +
							"\nSaldo: R$ " + cc.Saldo);
						}
						else if (op == 2)
						{
							Console.WriteLine("Informe o valor para saque: ");
							double valor = Double.Parse(Console.ReadLine());

							if (valor <= cc.Saldo)
								cc.Saldo -= valor;
							else
								Console.WriteLine("Saldo insuficiente");
						}
						else if (op == 3)
						{
							Console.WriteLine("Informe o valor para deposito: ");
							double valor = Double.Parse(Console.ReadLine());

							cc.Saldo += valor;
						}
					}
					catch
					{
						Console.WriteLine("Conta inválida!");
					}
			}
				else if (tipoConta == 2)
				{
					agencia.findAllCPoupanca();
					Console.WriteLine("Informe o numero da conta: ");
					int numConta = int.Parse(Console.ReadLine());

					try
					{
						var cp = db.Set<ContaPoupanca>().First(p => p.Id == numConta);	//Update Conta Poupança in banco

						Console.WriteLine(
							"1 - Consultar Saldo\n" +
							"2 - Sacar\n" +
							"3 -  Depositar");
						int op = int.Parse(Console.ReadLine());

						if (op == 1)
						{
							Console.WriteLine(
							"Conta = " + cp.Id +
							"\nTitular = " + cp.Titular +
							"\nSeu saldo é = R$ " + cp.Saldo);
						}
						else if (op == 2)
						{
							Console.WriteLine("Informe o valor para saque: ");
							double valor = Double.Parse(Console.ReadLine());

							if (valor <= cp.Saldo)
								cp.Saldo -= valor;
							else
								Console.WriteLine("Saldo insuficiente");
						}
						else if (op == 3)
						{
							Console.WriteLine("Informe o valor para deposito: ");
							double valor = Double.Parse(Console.ReadLine());

							cp.Saldo += valor;
						}
					}
					catch
					{
						Console.WriteLine("Conta inválida!");
					}
				}
				db.SaveChanges();	//Save banco
			}
        }
    }
}
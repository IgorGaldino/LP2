using System;
using System.Collections.Generic;
using System.Linq;
using Atividade2EFCore.Model;

namespace Atividade2EFCore
{
    class Program
    {
		const double JUROS = 0.6;

        static void Main(string[] args)
        {

            using (var db = new StoreContext())
            {
				Banco banco = verificaBanco();

                db.Bancos.Add(banco);
                db.SaveChanges();

                while (true)
                {
                    menu();
                    int op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Agencia agencia = new Agencia();
                        agencia.Banco = banco;
                        db.Agencias.Add(agencia);  //add agência in banco
                        db.SaveChanges();
                        banco.findAllAgencia();

                    }
                    else if (op == 2)
                    {
						banco.findAllAgencia();
						Console.WriteLine("Informe o número da agência: ");
                        int numAgencia = int.Parse(Console.ReadLine());
                        Agencia agencia = banco.findAgencia(numAgencia);

                        if (agencia == null)
                        {
                            Console.WriteLine(
								"*************************************\n" + 
								"**Agencia inválida! Tente novamente**\n" +
								"*************************************\n");
                            continue;
                        }

                        Cliente cliente = new Cliente();
                        
                        Console.WriteLine("Informe o nome do cliente: ");
                        cliente.Nome = Console.ReadLine();

                        Console.WriteLine("Qual tipo de conta deseja criar:");
                        Console.WriteLine("1 - Corrente | 2 - Poupança");
                        int tipoConta = int.Parse(Console.ReadLine());
                        if (tipoConta == 1)
                        {

                            db.Clientes.Add(cliente);   //add cliente in base
                            ContaCorrente cc = new ContaCorrente(cliente.Nome, agencia);
							var x = db.ContasCorrente.Add(cc);  //add Conta Corrente in base
                        }
                        else if (tipoConta == 2)
                        {
                            db.Clientes.Add(cliente);   //add cliente in base
                            ContaPoupanca cp = new ContaPoupanca(JUROS, DateTime.Now, cliente.Nome, agencia);
                            db.ContasPoupanca.Add(cp);  //add Conta Poupança in base
                        }
                    }
                    else if (op == 3)
                    {
                        Solicitacao solicitacao = new Solicitacao();
                        solicitacao.realizarSolicitacao(banco);
                    }
                    else if (op == 4)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine(
							"***********************************\n" +
							"**Opção inválida! Tente novamente**\n" +
							"***********************************\n");
                    }
                    db.SaveChanges();
                } //Fim do while
            }
        } //Fim da main


        public static void menu()
        {
            Console.WriteLine(
				"\n\t##Sistema de Banco##\n\n" +
                "1 - Cadastrar Agência\n" +
                "2 - Criar Conta\n" +
                "3 - Abrir uma Sessão\n" +
                "4 - Encerrar programa\n"
            );
        }

		public static Banco verificaBanco()
		{
			using (var db = new StoreContext())
			{
				try
				{
					return db.Bancos
					.Single(b => b.Id == 1);
				}
				catch
				{
					return new Banco();
				}
			}
		}
    }
}

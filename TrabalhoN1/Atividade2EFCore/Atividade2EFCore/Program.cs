using System;
using System.Collections.Generic;
using Atividade2EFCore.Model;

namespace Atividade2EFCore
{
    class Program
    {
        public const double JUROS = 0.6;

        static void Main(string[] args)
        {
            int contCliente = 0;
            int contCCorrente = 0;
            int contCPoupanca = 0;
            
            using (var db = new StoreContext())
            {
                db.Set<Cliente>().RemoveRange(db.Clientes);
                db.Set<Banco>().RemoveRange(db.Bancos);
                db.Set<Agencia>().RemoveRange(db.Agencias);
                db.Set<ContaCorrente>().RemoveRange(db.ContasCorrente);
                db.Set<ContaPoupanca>().RemoveRange(db.ContasPoupanca);
                db.Set<Solicitacao>().RemoveRange(db.Solicitacoes);
                db.SaveChanges();

                Banco banco = new Banco();

                /*
                    db.Clientes.Add(new Cliente { Nome = "igor" });
                    db.Clientes.Add(new Cliente { Nome = "Zé" });
                    db.SaveChanges();
                */

                while (true)
                {
                    //banco.showIdAgencias();
                    menu();
                    int op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Agencia agencia = new Agencia();
                        db.Agencias.Add(agencia);  //add agência in banco
                        db.SaveChanges();
                        banco.showIdAgencias();
                        //banco.addAgencia(agencia);

                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Informe o número da agência: ");
                        int numAgencia = int.Parse(Console.ReadLine());
                        Agencia agencia = banco.findAgencia(numAgencia);

                        if (agencia == null)
                        {
                            Console.WriteLine("Agencia inválida! Tente novamente!\n");
                            continue;
                        }

                        Cliente cliente = new Cliente();
                        //cliente.Id = ++contCliente;
                        Console.WriteLine("Informe o nome do cliente: ");
                        string nome = Console.ReadLine();
                        cliente.Nome = nome;

                        Console.WriteLine("Qual tipo de conta deseja criar:");
                        Console.WriteLine("1 - Corrente | 2 - Poupança");
                        int tipoConta = int.Parse(Console.ReadLine());
                        if (tipoConta == 1)
                        {
                            cliente.Id = ++contCliente;
                            db.Clientes.Add(cliente);   //add cliente in base
                            ContaCorrente cc = new ContaCorrente(cliente.Nome);
                            cc.Id = ++contCCorrente;
                            db.ContasCorrente.Add(cc);  //add Conta Corrente in base
                            agencia.addCCorrente(cc);

                        }
                        else if (tipoConta == 2)
                        {
                            cliente.Id = ++contCliente;
                            db.Clientes.Add(cliente);   //add cliente in base
                            ContaPoupanca cp = new ContaPoupanca(JUROS, DateTime.Now, cliente.Nome);
                            cp.Id = ++contCPoupanca;
                            db.ContasPoupanca.Add(cp);  //add Conta Poupança in base
                            agencia.addCPoupanca(cp);

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
                        Console.WriteLine("Opção inválida, tente novamente");
                    }
                    db.SaveChanges();
                } //Fim do while
            }
        } //Fim da main

        public static void menu()
        {
            Console.WriteLine(
                "##Sistema de Banco##\n\n" +
                "1 - Cadastrar Agência\n" +
                "2 - Criar Conta\n" +
                "3 - Abrir uma Sessão\n" +
                "4 - Encerrar programa\n"
            );
        }
    }
}

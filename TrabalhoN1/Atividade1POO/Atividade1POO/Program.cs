using System;

namespace Atividade1POO
{
    class Program
    {
        public const double JUROS = 0.6;

        static void Main(string[] args)
        {
            int contAgencia = 0;
            int contCCorrente = 0;
            int contCPoupanca = 0;

            Banco banco = new Banco();
            while (true)
            {
                //banco.showIdAgencias();
                menu();
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    //contAgencia++;
                    Agencia agencia = new Agencia();
                    agencia.Id = ++contAgencia;
                    banco.addAgencia(agencia);

                }
                else if (op == 2)
                {
                    Console.WriteLine("Informe o n�mero da ag�ncia: ");
                    int numAgencia = int.Parse(Console.ReadLine());
                    Agencia agencia = banco.findAgencia(numAgencia);

                    if (agencia == null)
                    {
                        Console.WriteLine("Agencia inv�lida! Tente novamente!");
                        continue;
                    }

                    Cliente cliente = new Cliente();
                    Console.WriteLine("Informe o nome do cliente: ");
                    string nome = Console.ReadLine();
                    cliente.Nome = nome;

                    Console.WriteLine("Qual tipo de conta deseja criar:");
                    Console.WriteLine("1 - Corrente | 2 - Poupan�a");
                    int tipoConta = int.Parse(Console.ReadLine());
                    if (tipoConta == 1)
                    {
                        ContaCorrente cc = new ContaCorrente(cliente.Nome);

                        cc.Id = ++contCCorrente;
                        agencia.addCCorrente(cc);

                    }
                    else if (tipoConta == 2)
                    {
                        ContaPoupanca cp = new ContaPoupanca(JUROS, DateTime.Now, cliente.Nome);

                        cp.Id = ++contCPoupanca;
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
                    Console.WriteLine("Op��o inv�lida, tente novamente");
                }
            }
        }

        public static void menu()
        {
            Console.WriteLine(
                "##Sistema de Banco##\n\n" +
                "1 - Cadastrar Ag�ncia\n" +
                "2 - Criar Conta\n" +
                "3 - Abrir uma Sess�o\n" +
                "4 - Encerrar programa\n"
            );
        }
    }
}
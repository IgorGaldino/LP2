using System;

namespace Atividade1POO
{
    public class Solicitacao
    {
        public int Id { get; set; }

        public void realizarSolicitacao(Banco banco)
        {
            Console.WriteLine("Informe o Id da agência: ");
            int numAgencia = int.Parse(Console.ReadLine());

            Agencia agencia = banco.findAgencia(numAgencia);
            if (agencia == null)
            {
                Console.WriteLine("Agência não existe!\n");
                return;
            }
            Console.WriteLine(
                "Informe o tipo da conta:\n" +
                "1 - Corrente\n" +
                "2 - Poupança");

            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            if (tipoConta == 1)
            {
                ContaCorrente cc = agencia.getCCorrente(numConta);

                if (cc == null) return;

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
                        cc.sacar(valor);
                    else
                        Console.WriteLine("Saldo insuficiente");

                }
                else if (op == 3)
                {
                    Console.WriteLine("Informe o valor para deposito: ");
                    double valor = Double.Parse(Console.ReadLine());

                    cc.depositar(valor);
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else if (tipoConta == 2)
            {
                ContaPoupanca cp = agencia.getCPoupanca(numConta);
                if (cp == null) return;

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
                        cp.sacar(valor);
                    else
                        Console.WriteLine("Saldo insuficiente");
                }
                else if (op == 3)
                {
                    Console.WriteLine("Informe o valor para deposito: ");
                    double valor = Double.Parse(Console.ReadLine());

					cp.depositar(valor);
                }
            }
        }
    }
}
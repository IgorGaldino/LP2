using System;
using System.Collections.Generic;

namespace Atividade1POO
{
    public class Agencia
    {

        List<ContaCorrente> contasCorrente = new List<ContaCorrente>();
        List<ContaPoupanca> contasPoupanca = new List<ContaPoupanca>();
        List<Solicitacao> solicitacoes = new List<Solicitacao>();

        public int Id { get; set; }

        public List<ContaCorrente> ContasCorrente { get; set; }
        public List<ContaPoupanca> ContasPoupanca { get; set; }
        public List<Solicitacao> Solicitacoes { get; set; }

        public void addCCorrente(ContaCorrente cc)
        {
            contasCorrente.Add(cc);
            Console.WriteLine("N�mero da conta corrente " + cc.Id + " de titular " + cc.Titular + " criada com sucesso!");
        }

        public void addCPoupanca(ContaPoupanca cp)
        {
            contasPoupanca.Add(cp);
            Console.WriteLine("N�mero da conta poupan�a " + cp.Id + " de titular " + cp.Titular + " criada com sucesso!");
        }

        public ContaCorrente getCCorrente(int num)
        {
            ContaCorrente cc = null;
            foreach (var conta in contasCorrente)
            {
                if (conta.Id == num)
                {
                    cc = conta;
                    return cc;
                }
            }

            Console.WriteLine("N�mero da conta inv�lido! Tente novamente");

            return null;
        }

        public ContaPoupanca getCPoupanca(int num)
        {
            ContaPoupanca cp = null;
            foreach (var conta in contasPoupanca)
            {
                if (conta.Id == num)
                {
                    cp = conta;
                    return cp;
                }
            }
            Console.WriteLine("N�mero da conta inv�lido! Tente novamente");

            return null;
        }
    }
}
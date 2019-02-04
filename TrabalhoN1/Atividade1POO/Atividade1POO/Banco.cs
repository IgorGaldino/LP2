using System;
using System.Collections.Generic;

namespace Atividade1POO
{
    public class Banco
    {

        List<Agencia> agencias = new List<Agencia>();

        public int Id { get; set; }
        public List<Agencia> Agencias { get; }

        public void addAgencia(Agencia a)
        {
            agencias.Add(a);
            Console.WriteLine("Agência " + a.Id + " criada com sucesso!");
            Console.WriteLine("Numero de agencias: " + agencias.Count + "\n");
        }

        public Agencia findAgencia(int num)
        {
            Agencia agencia = null;
            foreach (var ag in agencias)
            {
                if (ag.Id == num)
                {
                    agencia = ag;
                    return agencia;
                }
            }

            return null;
        }

        public void showIdAgencias()
        {
            Console.WriteLine("Agencias");
            foreach (var agencia in agencias)
            {
                Console.WriteLine("Agencia: " + agencia.Id);
            }
            Console.WriteLine("");
        }

    }
}
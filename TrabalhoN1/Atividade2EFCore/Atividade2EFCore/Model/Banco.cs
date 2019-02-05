using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Atividade2EFCore.Model;
using System.Linq;

namespace Atividade2EFCore
{
    public class Banco
    {

        List<Agencia> agencias = new List<Agencia>();
        
        //[Key]
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
            using (var db = new StoreContext())
            {
                try
                {
                    var agencia = db.Agencias
                    .Single(a => a.Id == num);
                    return agencia;
                }
                catch (Exception)
                {
                    return null;
                }
                /*Agencia agencia = null;
                foreach (var ag in agencias)
                {
                    if (ag.Id == num)
                    {
                        agencia = ag;
                        return agencia;
                    }
                }

                return null;*/
            }
        }

        public void showIdAgencias()
        {
            using (var db = new StoreContext())
            {
                var agencias = db.Set<Agencia>();
                Console.WriteLine("\nLista das Agencias\n");
                foreach (var agencia in agencias)
                {
                    Console.WriteLine("Agencia de número: " + agencia.Id);
                }
                Console.WriteLine("");
            }
        }

    }
}

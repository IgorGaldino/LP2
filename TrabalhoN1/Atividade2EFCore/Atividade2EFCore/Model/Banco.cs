using System;
using System.Collections.Generic;
using System.Linq;
using Atividade2EFCore.Model;

namespace Atividade2EFCore
{
    public class Banco
    {
		public Banco()
        {
            Agencias = new List<Agencia>();
        }
        public int Id { get; set; }
        public ICollection<Agencia> Agencias { get; set; }

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
            }
        }

        public void findAllAgencia()
        {
            using (var db = new StoreContext())
            {
				try
				{
					var agencias = db.Set<Agencia>();
					Console.WriteLine(
						"######################\n" +
						"##Lista das Agencias##\n" +
						"######################\n");
					foreach (var agencia in agencias)
					{
						Console.WriteLine("Agencia de número: " + agencia.Id);
					}
					Console.WriteLine("");
				} catch(Exception)
				{
					return;
				}
            }
        }

    }
}

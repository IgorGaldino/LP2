using System;
using System.Collections;
using System.Collections.Generic;

namespace crudPessoas
{
    public class Pessoas
    {
        private ArrayList pessoas = new ArrayList();

        public void create(string nome, int idade)
        {
            Pessoa pessoa = new Pessoa(nome, idade);
            pessoas.Add(pessoa);
        }

        public void read()
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                Pessoa p = (Pessoa) pessoas[i];
                Console.WriteLine("id: " + (i + 1));
                Console.WriteLine("Nome: " + p.Nome);
                Console.WriteLine("Idade: " + p.Idade);
                Console.WriteLine("");  
            }
            
        }

        public void update(int index, string nome, int idade)
        {
            Pessoa p = (Pessoa) pessoas[index];
            p.Nome = nome;
            p.Idade = idade;
        }
        
        public void delete(int index)
        {
            pessoas.RemoveAt(index);
        }
        
    }
}
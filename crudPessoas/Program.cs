using System;
using System.Collections;
using System.Collections.Generic;

namespace crudPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoas = new Pessoas();
            int op = 0, id = 0, idade = 0;
            string nome = "";
            do
            {
                Console.WriteLine("\nCrud usuário");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Adicionar usuário");
                Console.WriteLine("3 - Editar usuário");
                Console.WriteLine("4 - Remover usuário");
                Console.WriteLine("0 - Sair");

                op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        pessoas.read();
                        break;
                    case 2:
                        Console.WriteLine("Informe o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Informe o idade: ");
                        idade = Int32.Parse(Console.ReadLine());
                        pessoas.create(nome, idade);
                        break;
                    case 3:
                        Console.WriteLine("Informe o id: ");
                        id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Informe o idade: ");
                        idade = Int32.Parse(Console.ReadLine());
                        pessoas.update(id-1, nome, idade);
                        break;
                    case 4:
                        Console.WriteLine("Informe o id: ");
                        id = Int32.Parse(Console.ReadLine());
                        pessoas.delete(id-1);
                        break;
                    case 0:
                        break;
                    default: 
                        Console.WriteLine("Opção inválida!!!\n");
                        break;
                }


            }while(op != 0);

        }
    }
}

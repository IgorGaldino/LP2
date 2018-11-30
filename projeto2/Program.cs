using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List Generic*/
            /*
                List<int> list = new List<int>();
                list.Add(12);
                list.Add(32);
                list.Add(50);
                list.Add("Teste");      //Erro! tipo inválido

                int[] outralista = new int[] {1,2,3,4};
                list.AddRange(outralista);

                list.Insert(0,12);
                list.Insert(1,32);
                list.Insert(1,50);
                list.Insert(3,44);
                // list.Insert(10, 100);
                Console.WriteLine("TEste: " + list[1]);
                Console.WriteLine("TEste: " + list[2]);
            */
            /* Aluno com ArrayList */
            Alunos listaAlunos = new Alunos();

            Aluno alunoJose = new Aluno() {Codigo = 100, Nome ="Jose"};
            listaAlunos.incluirAluno(alunoJose);

            Aluno alunoMaria = new Aluno() {Codigo = 200, Nome ="Maria"};
            listaAlunos.incluirAluno(alunoMaria);

            ArrayList lista = listaAlunos.listarALunos();
            StringBuilder stringAluno = new StringBuilder();

            for (int i = 0; i < lista.Count; i++)
            {
                Aluno alunoSel = (Aluno)lista[i];
                String temp = alunoSel.Nome + " - " + alunoSel.Codigo + "\n";
                stringAluno.Append(temp);
            }

            Console.WriteLine(stringAluno.ToString());
        }
    }
}

using System;
using System.Collections;
using System.Text;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
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

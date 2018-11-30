using System;
using System.Collections;
public class Alunos 
{
    private ArrayList listaAlunos = new ArrayList();
    public void incluirAluno(Aluno a)
    {
        listaAlunos.Add(a);
    }

    public ArrayList listarALunos() 
    {
        return listaAlunos;
    }
}
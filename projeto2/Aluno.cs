using System;
public class Aluno 
{
    private int codigo = 0;
    private string  nome  = string.Empty;

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}
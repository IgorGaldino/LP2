namespace crudPessoas
{
    public class Pessoa
    {
        private string nome = string.Empty;
        private int idade = 0;

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
namespace atvCarro
{
    public class Veiculo
    {
        private string cor = string.Empty;
        private string modelo = string.Empty;
        private string fabricante = string.Empty;
        private int ano = 0;

        public Veiculo(int ano)
        {
            Ano = ano;
        }
        
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }

    }
}
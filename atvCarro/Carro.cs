namespace atvCarro
{
    public class Carro : Veiculo
    {
        private int numeroDePortas = 0;
        private string tipoCombustivel = string.Empty;

        public Carro(int ano) : base(ano) {}
        public Carro(int ano, int numeroDePortas) : base(ano) 
        {
            NumeroDePortas = numeroDePortas;
        }

        public int NumeroDePortas { get; set; }
        public string TipoCombustivel { get; set; }
    }
}
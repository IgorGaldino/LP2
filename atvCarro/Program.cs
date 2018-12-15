using System;

namespace atvCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro fiat = new Carro(2015);
            Carro gol = new Carro(2012);
            Carro voyage = new Carro(2019, 5);
            Bicicleta caloi = new Bicicleta(2017);

            fiat.Ano = 2018;

            Console.WriteLine("Voyage Ano: " + voyage.Ano);
            Console.WriteLine("Voyage Número de portas: " + voyage.NumeroDePortas);
        }
    }
}

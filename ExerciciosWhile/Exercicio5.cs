using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Util;

namespace ExerciciosWhile
{
    public class Exercicio5
    {
        public void Executar()
        {
            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidade = ConsoleEx.ReadLineAsInt();

            List<Carro> carros = new List<Carro>();

            while (carros.Count < quantidade)
            {
                Console.Clear();
                Carro carro = new Carro();

                Console.Write("Modelo: ");
                carro.Modelo = ConsoleEx.ReadLineAsString();

                Console.Write("Valor: ");
                carro.Valor = ConsoleEx.ReadLineAsDouble();

                Console.Write("Ano: ");
                carro.Ano = ConsoleEx.ReadLineAsInt();

                carros.Add(carro);
            }

            Console.Clear();

            double mediaAno = carros.Average(x => x.Ano);
            double mediaValor = carros.Average(x => x.Valor);
            int quantidadeLetraG = carros.Where(x => x.Modelo.ToLower().StartsWith('g')).Count();
            int quantidadeLetraA = carros.Where(x => x.Modelo.ToLower().StartsWith('a')).Count();

            Console.WriteLine($"Média de ano: {mediaAno:F1}");
            Console.WriteLine($"Média de valor: {mediaValor:C2}");
            Console.WriteLine($"Quantidade de modelos começando com a letra 'G': {quantidadeLetraG}");
            Console.WriteLine($"Quantidade de modelos começando com a letra 'A': {quantidadeLetraA}");

            Thread.Sleep(2000);
        }
    }

    class Carro
    {
        public string Modelo { get; set; }
        public double Valor { get; set; }
        public int Ano { get; set; }

        public Carro()
        {
        }
    }
}

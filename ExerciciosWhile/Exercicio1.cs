using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Util;

namespace ExerciciosWhile
{
    public class Exercicio1
    {
        public void Executar()
        {
            List<Tuple<string, double>> pecas = new List<Tuple<string, double>>();

            while (pecas.Count < 13)
            {
                Console.Clear();

                Console.Write("Informe o nome da peça: ");
                string nome = ConsoleEx.ReadLineAsString();

                Console.Write("Informe o preço da peça: ");
                double preco = ConsoleEx.ReadLineAsDouble();

                pecas.Add(new Tuple<string, double>(nome, preco));
            }

            Console.Clear();
            Console.WriteLine("Lista de peças:");
            foreach (Tuple<string, double> peca in pecas)
            {
                Console.WriteLine($"Nome: {peca.Item1}, Preço: {peca.Item2}");
            }

            Thread.Sleep(2000);
        }
    }
}

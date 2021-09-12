using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Util;

namespace ExerciciosWhile
{
    public class Exercicio4
    {
        public void Executar()
        {
            int quantidade = 0;
            double peso = 0;

            while (peso >= 0 && peso <= 300)
            {
                Console.Clear();

                Console.Write("Insira o peso: ");
                peso = ConsoleEx.ReadLineAsDouble(true);
                quantidade++;
            }

            Console.WriteLine($"Quantidade de pessoas que informaram o peso: {quantidade}");

            Thread.Sleep(2000);
        }
    }
}

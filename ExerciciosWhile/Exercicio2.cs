using System;
using System.Collections.Generic;
using System.Threading;
using Util;

namespace ExerciciosWhile
{
    public class Exercicio2
    {
        public void Executar()
        {
            List<string> nomes = new List<string>();

            while (true)
            {
                string nome = "";

                Console.Clear();
                Console.Write("Digite o nome ('fim' para encerrar): ");
                nome = ConsoleEx.ReadLineAsString();

                if (nome.ToLower() == "fim")
                    break;

                nomes.Add(nome);
            }

            Console.Clear();

            nomes.Sort();

            Console.WriteLine("Nomes inseridos:");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Thread.Sleep(2000);
        }
    }
}

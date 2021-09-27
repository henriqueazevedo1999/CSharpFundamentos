using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExercíciosVectorFor
{
    public class Exercicio1
    {
        public static void Executar()
        {
            string[] nomes = new string[25];

            Console.Clear();

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Insira o {i + 1}° nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("Nomes inseridos:");

            nomes.ToList().ForEach(nome => Console.WriteLine(nome));

            Thread.Sleep(2000);
        }
    }
}

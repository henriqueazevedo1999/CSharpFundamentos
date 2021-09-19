using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Util;

namespace ExerciciosFor
{
    public static class Exercicio1
    {
        public static void Executar()
        {
            bool numeroOk = false;
            int numero = 0;

            Console.Clear();

            do
            {
                Console.Write("Informe o número que deseja obter a tabuada: ");

                numeroOk = ConsoleEx.ReadLineAsInt(out numero);

                if (numeroOk)
                    break;
            
                Console.WriteLine("Número inválido!");
            } while (!numeroOk);

            Console.Clear();

            Console.WriteLine($"A tabuada de 0 a 10 de {numero} é:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Thread.Sleep(2000);
        }
    }
}

using System;
using System.Threading;

namespace ExerciciosFor
{
    public static class Exercicio3
    {
        public static void Executar()
        {
            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }

            Thread.Sleep(2000);
        }
    }
}

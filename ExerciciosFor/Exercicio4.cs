using System;

namespace ExerciciosFor
{
    public static class Exercicio4
    {
        public static void Executar()
        {
            Console.Clear();
            int quantidade = 21;

            for (int i = 1; i <= quantidade; i++)
            {
                for (int j = 1; j <= quantidade; j++)
                {
                    Console.Write("*");
                    if (j != quantidade)
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}

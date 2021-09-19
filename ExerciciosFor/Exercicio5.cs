using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciciosFor
{
    public static class Exercicio5
    {
        public static void Executar()
        {
            Console.Clear();
            int quantidade = 21;

            for (int i = 1; i <= quantidade; i++)
            {
                for (int j = 1; j <= quantidade; j++)
                {
                    if (i == 1 || i == quantidade)
                    {
                        Console.Write("*");
                        if (j != quantidade)
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j == 1 || j == quantidade)
                            Console.Write("*");
                        else 
                            Console.Write(" ");
                        
                        if (j != quantidade)
                            Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

            Thread.Sleep(2000);
        }
    }
}

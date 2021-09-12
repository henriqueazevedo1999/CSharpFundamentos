using System;
using System.Collections.Generic;
using System.Linq;
using Util;

namespace ExerciciosWhile
{
    public class Exercicio3
    {
        public void Executar()
        {
            int idade = 0;
            while (idade <= 128)
            {
                Console.Clear();

                Console.Write("Digite a idade (maior que 128 para parar): ");
                idade = ConsoleEx.ReadLineAsInt();
            }
        }
    }
}

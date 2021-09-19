using System;
using Util;

namespace ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a opção desejada: ");

            int opcaoDesejada = ConsoleEx.ReadLineAsInt();

            switch (opcaoDesejada)
            {
                case 1:
                    Exercicio1.Executar();
                    break;

                case 3:
                    Exercicio3.Executar();
                    break;

                case 4:
                    Exercicio4.Executar();
                    break;

                case 5:
                    Exercicio5.Executar();
                    break;
            }
        }
    }
}

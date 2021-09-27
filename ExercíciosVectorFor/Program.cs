using System;
using Util;

namespace ExercíciosVectorFor
{
    class Program
    {
        //https://drive.google.com/drive/folders/1TLeafkW7QYNeo4UnbeZnqZZ08MI12H2N
        //1,2,4,6
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção desejada: ");
            int opcaoDesejada = ConsoleEx.ReadLineAsInt();

            switch (opcaoDesejada)
            {
                case 1:
                    {
                        Exercicio1.Executar();
                        break;
                    }

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}

using System;
using Util;

namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoSelecionada = 0;
            bool encerrar = false;

            do
            {
                Console.Write("Digite a opção desejada (99 para sair): ");
                opcaoSelecionada = ConsoleEx.ReadLineAsInt(true);

                Console.Clear();
                switch (opcaoSelecionada)
                {
                    case 1:
                        Exercicio1 exercicio1 = new Exercicio1();
                        exercicio1.Executar();
                        break;

                    case 2:
                        Exercicio2 exercicio2 = new Exercicio2();
                        exercicio2.Executar();
                        break;

                    case 3:
                        Exercicio3 exercicio3 = new Exercicio3();
                        exercicio3.Executar();
                        break;

                    case 4:
                        Exercicio4 exercicio4 = new Exercicio4();
                        exercicio4.Executar();
                        break;

                    case 5:
                        Exercicio5 exercicio5 = new Exercicio5();
                        exercicio5.Executar();
                        break;

                    //TODO: CORRIGIR FUNCIONAMENTO
                    case 9:
                        Exercicio9 exercicio9 = new Exercicio9();
                        exercicio9.Executar();
                        break;

                    case 99:
                        encerrar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (!encerrar);
        }
    }
}

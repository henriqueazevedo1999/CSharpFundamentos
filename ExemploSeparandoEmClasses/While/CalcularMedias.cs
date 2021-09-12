using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Util;

namespace ExemploSeparandoEmClasses.While
{
    internal class CalcularMedias
    {
        public CalcularMedias()
        {
        }

        internal void Executar()
        {
            Console.Write("Quantidade de alunos para calcular a média: ");
            int quantidadeDesejada = ConsoleEx.ReadLineAsInt();
            int quantidadeCalculada = 0;

            int quantidadeAprovado = 0;
            int quantidadeReprovado = 0;
            int quantidadeExame = 0;
            int quantidadeMedia10 = 0;

            List<double> medias = new List<double>();

            while (quantidadeCalculada < quantidadeDesejada)
            {
                Console.Clear();

                Console.Write("Nota 1: ");
                double nota1 = LeNota();

                Console.Write("Nota 2: ");
                double nota2 = LeNota();

                Console.Write("Nota 3: ");
                double nota3 = LeNota();

                double media = (nota1 + nota2 + nota3) / 3;
                medias.Add(media);

                if (media >= 7)
                    quantidadeAprovado++;
                else if (media >= 5)
                    quantidadeExame++;
                else
                    quantidadeReprovado++;

                if (media == 10)
                    quantidadeMedia10++;

                Console.WriteLine($"Média: {media:F2}");
                
                Thread.Sleep(2000);

                quantidadeCalculada++;
            }

            double percentualAlunosAprovados = quantidadeAprovado * 100.0 / quantidadeDesejada;

            Console.WriteLine($"Quantidade de alunos aprovados:    {medias.Where(x => x >= 7).Count()}");
            Console.WriteLine($"Quantidade de alunos reprovados:   {medias.Where(x => x < 5).Count()}");
            Console.WriteLine($"Quantidade de alunos em exame:     {medias.Where(x => x >= 5 && x < 7).Count()}");
            Console.WriteLine($"Quantidade de alunos que media 10: {medias.Where(x => x == 10).Count()}");

            Console.WriteLine();

            Console.WriteLine($"Quantidade de alunos aprovados:    {quantidadeAprovado}");
            Console.WriteLine($"Quantidade de alunos reprovados:   {quantidadeReprovado}");
            Console.WriteLine($"Quantidade de alunos em exame:     {quantidadeExame}");
            Console.WriteLine($"Quantidade de alunos que media 10: {quantidadeMedia10}");
            Console.WriteLine();
            Console.WriteLine($"{percentualAlunosAprovados:F2}% dos alunos foi aprovado");
        }

        private double LeNota()
        {
            double nota = 0;
            do
            {
                nota = ConsoleEx.ReadLineAsDouble();
            } while (!ValidaNota(nota));

            return nota;
        }

        private bool ValidaNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
                return true;

            Console.WriteLine("Nota inválida.");
            return false;
        }
    }
}
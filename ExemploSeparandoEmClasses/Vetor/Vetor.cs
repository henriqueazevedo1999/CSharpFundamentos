using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using Util;

namespace ExemploSeparandoEmClasses.Vetor
{
    public class Vetor
    {
        #region Exemplo01
        public void Exemplo01()
        {
            Console.Clear();

            string[] nomes = new string[6];

            nomes[0] = "Lucas";
            nomes[1] = "Paulo";
            nomes[2] = "Pamela";
            nomes[3] = "Julia";
            nomes[4] = "Francisco";
            nomes[5] = "Pedro";

            ApresentaNomes(nomes);

            Thread.Sleep(2000);
        }

        private void ApresentaNomes(string[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"{i + 1}° nome: {vetor[i]}");
            }
        }
        #endregion

        #region Exemplo02
        private void Exemplo02()
        {
            int[] numeros = new int[7];
            numeros[0] = 1;
            numeros[1] = 20;
            numeros[2] = 19;
            numeros[3] = 10;
            numeros[4] = 30;
            numeros[5] = 22;
            numeros[6] = 18;

            ApresentaNumeros(numeros);

            Console.WriteLine($"Soma: {numeros.Sum()}");

            Thread.Sleep(2000);
        }

        private void ApresentaNumeros(int[] numeros)
        {
            Console.WriteLine("Números:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"[{i}] => {numeros[i]}");
            }
        }
        #endregion

        #region Exemplo03
        private void Exemplo03()
        {
            int quantidadeMaxima = 3;

            string[] clientes = new string[quantidadeMaxima];
            string[] nomes = new string[quantidadeMaxima];
            int[] quantidades = new int[quantidadeMaxima];
            double[] precosUnitarios = new double[quantidadeMaxima];
            double[] precosTotais = new double[quantidadeMaxima];

            for (int i = 0; i < quantidadeMaxima; i++)
            {
                Console.WriteLine($"[{i + 1}/{quantidadeMaxima}]");

                Console.Write("Digite o nome do cliente: ");
                clientes[i] = ConsoleEx.ReadLineAsString();

                Console.Write("Digite o nome do produto: ");
                nomes[i] = ConsoleEx.ReadLineAsString();

                bool quantidadeOk;
                do
                {
                    Console.Write("Digite a quantidade: ");
                    quantidadeOk = ConsoleEx.ReadLineAsInt(out quantidades[i]);

                    if (!quantidadeOk)
                        Console.WriteLine("Quantidade inválida.");
                } while (!quantidadeOk);

                bool precoOk;
                do
                {
                    Console.Write("Digite o preço unitário: ");
                    precoOk = ConsoleEx.ReadLineAsDouble(out precosUnitarios[i]);

                    if (!precoOk)
                        Console.WriteLine("Preço inválido.");
                } while (!precoOk);

                precosTotais[i] = quantidades[i] * precosUnitarios[i];
                
                Console.Clear();
            }

            for (int i = 0; i < quantidadeMaxima; i++)
            {
                Console.WriteLine($"O cliente {clientes[i]} comprou {nomes[0]} a");
                Console.WriteLine($"quantidade {quantidades[i]} {precosUnitarios[0]:C2}.");
                Console.WriteLine($"Total: {precosTotais[i]:C2}");
            }

            Thread.Sleep(2000);
        }
        #endregion

        #region Exemplo04
        public void Exemplo04()
        {
            /*
             Calcular o boletim de um aluno
            solicitar o nome
            solicitar 4 notas para fisica, matematica, português, lógica e algoritmos, historia

            NOME: nome
            Portugues      Matematica      
            Nota 1: 7.0    Nota 1: 10.0
            Nota 2: 10.0   Nota 2: 5.79
            Nota 3: 9.79   Nota 3: 9.79
            Nota 4: 9.98   Nota 4: 9.98
            */

            Console.Clear();

            string nome = SolicitaNome();
            int quantidadeNotas = SolicitaQuantidadeNotas();

            Dictionary<string, double[]> materias = new();

            ResourceSet resourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach (DictionaryEntry entry in resourceSet)
            {
                materias.Add(entry.Value.ToString(), new double[quantidadeNotas]);
            }

            foreach (var materia in materias)
            {
                Console.Clear();
                Console.WriteLine(materia.Key);

                double[] notas = new double[materia.Value.Length];
                RequestGrades(ref notas);

                materias[materia.Key] = notas;
            }

            Console.WriteLine($"Nome: {nome}");
            ApresentaNotas(materias);

            Thread.Sleep(2000);
        }

        private void ApresentaNotas(Dictionary<string, double[]> materias)
        {
            int tamanhoMinimoColuna = 14;
            materias = Util.Util.GetOrderedDictionary(materias);

            Console.Clear();

            var linhas = new List<StringBuilder>();
            for (int i = 0; i < materias.FirstOrDefault().Value.Length + 2; i++)
                linhas.Add(new StringBuilder());

            foreach (var materia in materias)
            {
                int tamanhoColuna = Math.Max(tamanhoMinimoColuna, materia.Key.ToString().Length + 2);

                linhas[0].Append(materia.Key.ToString().PadRight(tamanhoColuna, ' '));

                for (int i = 1; i <= materia.Value.Length; i++)
                {
                    linhas[i].Append($"Nota {i}: {materia.Value[i - 1]:F2}".PadRight(tamanhoColuna, ' '));
                }

                linhas[materia.Value.Length + 1].Append($"Média:  {materia.Value.Average():F2}".PadRight(tamanhoColuna, ' '));
            }
            
            linhas.ToList().ForEach(linha => Console.WriteLine(linha.ToString()));
        }

        private string SolicitaNome()
        {
            Console.Write("Nome do aluno: ");
            return ConsoleEx.ReadLineAsString();
        }

        private void RequestGrades(ref double[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                bool gradeOk;
                do
                {
                    Console.Write($"Insira a {i + 1}ª nota: ");
                    gradeOk = ReadValueWithValidations(out grades[i], ValidateGrade);
                    if (!gradeOk)
                        Console.WriteLine("Nota inválida");

                } while (!gradeOk);
            }
        }

        private bool GetRandomGrade(out double grade)
        {
            grade = new Random().NextDouble() * 20;

            return true;
        }

        private int SolicitaQuantidadeNotas()
        {
            int quantidade = 0;
            bool quantidadeOk;
            do
            {
                Console.Write("Insira quantas notas deseja cadastrar: ");
                quantidadeOk = ConsoleEx.ReadValueWithValidations(out quantidade, ValidateNumberOfGrades);
                if (!quantidadeOk)
                    Console.WriteLine("Quantidade inválida.");
            } while (!quantidadeOk);
            
            return quantidade;
        }

        private bool ReadValueWithValidations(out double value, params Func<double, bool>[] validations)
        {
            bool valueOk = GetRandomGrade(out value); //ConsoleEx.ReadLineAsDouble(out value);
            if (!valueOk)
                return false;

            foreach (var validation in validations)
            {
                if (!validation(value))
                    return false;
            }

            return true;
        }

        private bool ValidateNumberOfGrades(int quantity)
        {
            return quantity > 0 && quantity < 10;
        }

        private bool ValidateGrade(double grade)
        {
            return grade <= 10 && grade >= 0;
        }
        #endregion
    }
}

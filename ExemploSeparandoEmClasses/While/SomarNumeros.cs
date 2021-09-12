using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Util;

namespace ExemploSeparandoEmClasses.While
{
    internal class SomarNumeros
    {
        public SomarNumeros()
        {
        }

        internal void Calcular()
        {
            string desejaContinuar = "";
            List<double> numeros = new List<double>();

            double maiorNumero = double.MaxValue;
            double menorNumero = double.MinValue;
            double soma = 0;
            int quantidade = 0;

            do
            {
                Console.Write("Informe o número a ser somado: ");
                double numero = ConsoleEx.ReadLineAsDouble();
                numeros.Add(numero);

                quantidade++;
                soma += numero;

                if (numero < menorNumero)
                    menorNumero = numero;

                if (numero > maiorNumero)
                    maiorNumero = numero;

                Console.Write("Digite 'sim' para continuar: ");
                desejaContinuar = ConsoleEx.ReadLineAsString();
            } while (desejaContinuar.ToLower() == "sim");

            double media = soma / quantidade;

            Console.WriteLine();
            Console.WriteLine($"Soma:   {soma:F2}");
            Console.WriteLine($"Média:  {media:F2}");
            Console.WriteLine($"Mínimo: {menorNumero:F2}");
            Console.WriteLine($"Máximo: {maiorNumero:F2}");
            
            double somaLinq = numeros.Sum();
            double mediaLinq = numeros.Average();
            double minimoLinq = numeros.Min();
            double maximoLinq = numeros.Max();

            Console.WriteLine($"Soma Linq:   {somaLinq:F2}");
            Console.WriteLine($"Média Linq:  {mediaLinq:F2}");
            Console.WriteLine($"Mínimo Linq: {minimoLinq:F2}");
            Console.WriteLine($"Máximo Linq: {maximoLinq:F2}");

            Thread.Sleep(2000);
        }
    }
}
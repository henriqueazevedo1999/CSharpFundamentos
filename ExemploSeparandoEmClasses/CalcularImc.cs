using System;
using System.Globalization;

namespace ExemploSeparandoEmClasses
{
    public class CalcularImc
    {
        public void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = ConsoleEx.ReadLineAsString().Trim();

            Console.Write("Digite sua altura: ");
            double altura = ConsoleEx.ReadLineAsDouble();

            Console.Write("Digite seu peso: ");
            double peso = ConsoleEx.ReadLineAsDouble();

            double imc = peso / (altura * altura);

            string resultado;

            if (imc < 18.5)
            {
                resultado = "Magreza";
            }
            else if (imc < 25)
            {
                resultado = "Normal";
            }
            else if (imc < 30)
            {
                resultado = "Pré-Obeso";
            }
            else if (imc < 35)
            {
                resultado = "Obesidade Grau I";
            }
            else if (imc < 40)
            {
                resultado = "Obesidade Grau II";
            }
            else
            {
                resultado = "Obesidade Grau III";
            }

            Console.Clear();

            Console.WriteLine($"Olá {nome}");
            Console.WriteLine($"Seu IMC é {imc:F2}");
            Console.WriteLine($"A classificação é: {resultado}");
        }
    }
}

using System;
using System.Globalization;

namespace Exemplo03_Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            //string to double
            double salario = Convert.ToDouble("1050.49", CultureInfo.InvariantCulture);
            Console.WriteLine($"Salario: {salario}");

            //string to char
            char letra = Convert.ToChar("A");
            Console.WriteLine($"Letra: {letra}");

            //string to bool
            bool empregado = Convert.ToBoolean("True");
            Console.WriteLine($"Empregado: {empregado}");
        }
    }
}

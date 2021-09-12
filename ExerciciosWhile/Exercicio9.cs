using System;
using System.Threading;
using Util;

namespace ExerciciosWhile
{
    //TODO: NÃO FUNCIONA
    public class Exercicio9
    {
        public void Executar()
        {
            Console.Write("Digite o número que deseja obter o fatorial: ");
            int numeroInicial = ConsoleEx.ReadLineAsInt();
            int numero = numeroInicial;
            int fatorial = numero - 1;

            while (numero > 0)
            {
                fatorial *= numero;
                numero--;
            }

            Console.Clear();

            Console.WriteLine($"O fatorial de {numeroInicial} é {fatorial}");

            Thread.Sleep(2000);
        }
    }
}

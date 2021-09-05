using System;
using System.Collections;
using System.Linq;

namespace ExercicioNumerosIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o número 1: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o número 2: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Números iguais!");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("Número 1 é maior");
            }
            else
            {
                Console.WriteLine("Número 2 é maior");
            }

            BitArray bNumero1 = new BitArray(new int[] { numero1 });
            bool[] bitsNumero1 = new bool[bNumero1.Count];
            bNumero1.CopyTo(bitsNumero1, 0);
            Array.Reverse(bitsNumero1);

            byte[] bitValuesNumero1 = bitsNumero1.Select(bit => (byte)(bit ? 1 : 0)).ToArray();

            BitArray bNumero2 = new BitArray(new int[] { numero2 });
            bool[] bitsNumero2 = new bool[bNumero2.Count];
            bNumero2.CopyTo(bitsNumero2, 0);
            Array.Reverse(bitsNumero2);

            byte[] bitValuesNumero2 = bitsNumero2.Select(bit => (byte)(bit ? 1 : 0)).ToArray();

        }
    }
}

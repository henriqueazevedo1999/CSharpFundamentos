using System;

namespace Exercicio01
{
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("     *");
            //Console.WriteLine("    ***");
            //Console.WriteLine("   *****");
            //Console.WriteLine("  *******");
            //Console.WriteLine(" *********");
            //Console.WriteLine("***********");

            string nome = "Henrique";
            string sobrenome = "Feliciano de Azevedo";

            Console.WriteLine($"{nome} {sobrenome}");

            /*
            Padrão de nomenclatura de variáveis:
            Correto:
                nome
                nomeCompletoDoAluno
                numero2
                x1
                x2
                descricao
            Errado:
                2numero
                %ansi
                nome_completo
                NomeCompleto
                descrição
            */

            int numero1 = 11;
            int numero2 = 22;

            Operacao operacao = new Operacao(numero1, numero2);
            Console.WriteLine(operacao.ToString());

            double valorGasolina = 5.60;
            int quantidadeLitros = 54;
            double valorTotal = valorGasolina * quantidadeLitros;

            Console.WriteLine($"Valor da gasolina por litro: {valorGasolina}");
            Console.WriteLine($"Quantidade de litros: {quantidadeLitros}");
            Console.WriteLine($"Total R$: {valorTotal}");

            bool empregado = false;
            Console.WriteLine($"Empregado: {empregado}");

            char caractere = 'A';
            Console.WriteLine($"Caractere: {caractere}");


        }
    }
}

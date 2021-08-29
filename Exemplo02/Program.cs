using System;
using System.Globalization;

namespace Exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            Livro livro = pedido.Livro;
            
            Console.Write("Nome do livro: ");
            livro.Nome = Console.ReadLine();

            Console.Write("Descrição livro: ");
            livro.Descricao = Console.ReadLine();

            Console.Write("Autor do livro: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Preço do livro: ");
            livro.Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de livros: ");
            pedido.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(pedido);
        }
    }
}

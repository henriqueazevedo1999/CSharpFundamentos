using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos que deseja inserir: ");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            Pedido pedido = new Pedido();

            for (int i = 1; i <= quantidadeProdutos; i++)
            {
                Produto produto = new Produto();

                Console.WriteLine($"Produto {i}");
                Console.Write("Nome: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                pedido.AdicionaProduto(produto, quantidade);

                Console.Clear();
            }

            Console.WriteLine(pedido.ToString());
            Console.WriteLine($"Total: {pedido.TotalPedido()}");
        }
    }
}

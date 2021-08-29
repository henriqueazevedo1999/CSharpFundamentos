using System;
using System.Globalization;
using System.Linq;

namespace Exercicio_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            PedidoJogo pedido = new PedidoJogo();

            Console.Write("Quantos jogos deseja adicionar ao pedido? ");
            
            int quantidadeJogos = Convert.ToInt32(Console.ReadLine());
            if (quantidadeJogos < 0)
                quantidadeJogos = 0;

            Console.Clear();

            for (int i = 0; i < quantidadeJogos; i++)
            {
                Jogo jogo = new Jogo();

                Console.WriteLine($"Jogo {pedido.Quantidade() + 1}");
                Console.Write("Nome: ");
                jogo.Nome = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("1 - Ação");
                Console.WriteLine("2 - RPG");
                Console.WriteLine("3 - Tiro");
                Console.WriteLine("4 - Construção");
                Console.Write("Digite o número da categoria: ");
                eCategorias categoria = (eCategorias)Convert.ToInt32(Console.ReadLine());
                jogo.Categoria = categoria.ToString();

                double desconto = 0.0;

                switch (categoria)
                {
                    case eCategorias.Acao:
                        desconto = 0.1;
                        jogo.Categoria = "Ação";
                        break;
                    case eCategorias.RPG:
                        desconto = 0.2;
                        jogo.Categoria = "RPG";
                        break;
                    case eCategorias.Tiro:
                        desconto = 0.25;
                        break;
                    case eCategorias.Construcao:
                        desconto = -0.25;
                        jogo.Categoria = "Construção";
                        break;
                }

                Console.Write("Preço: ");
                jogo.Preco = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture) * (1 - desconto);

                pedido.AdicionaJogo(jogo);
                Console.Clear();
            }

            Console.WriteLine(pedido.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Produtos
{
    public class Pedido
    {
        private Dictionary<Produto, int> lista = new Dictionary<Produto, int>();

        public Pedido()
        {
        }

        public void AdicionaProduto(Produto produto, int quantidade)
        {
            if (lista.ContainsKey(produto))
                lista[produto] += quantidade;
            else
                lista.Add(produto, quantidade);
        }

        public double TotalPedido()
        {
            double total = 0.0;

            foreach (Produto produto in lista.Keys)
                total += produto.Preco * lista[produto];

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int controleProdutos = 0;
            foreach (Produto produto in lista.Keys)
                sb.AppendLine($"Produto {++controleProdutos}: {produto.Nome} {lista[produto]} * {produto.Preco} " +
                    $"=> {GetTotalProduto(produto)}");

            return sb.ToString();
        }

        public double GetTotalProduto(Produto produto)
        {
            if (lista.ContainsKey(produto))
                return produto.Preco * lista[produto];

            return 0.0;
        }
    }
}

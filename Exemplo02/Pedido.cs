using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo02
{
    public class Pedido
    {
        public Livro Livro = new Livro();
        public int Quantidade;

        public double Total
        {
            get 
            {
                return Livro.Preco * Quantidade; 
            }
        }

        public Pedido()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Livro.ToString());
            sb.AppendLine($"Quantidade: {Quantidade}");
            sb.AppendLine($"Total: {Total}");

            return sb.ToString();

        }

    }
}

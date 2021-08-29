using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Jogo
{
    public class PedidoJogo
    {
        private List<Jogo> Jogos = new List<Jogo>();
        
        public PedidoJogo()
        {
        }

        public void AdicionaJogo(Jogo jogo)
        {
            Jogos.Add(jogo);
        }

        public double Total()
        {
            return Jogos.Select(x => x.Preco).Sum();
        }

        public string Categorias()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Jogos.Count(); i++)
            {
                sb.Append(Jogos[i].Categoria);

                if (i == Jogos.Count() - 1)
                    sb.Append('.');
                else if (i == Jogos.Count() - 2)
                    sb.Append(" e ");
                else
                    sb.Append(", ");
            }

            return sb.ToString();
        }

        public int Quantidade()
        {
            return Jogos.Count();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Resumo do pedido:");

            foreach (Jogo jogo in Jogos)
            {
                sb.AppendLine(jogo.ToString());
            }

            sb.AppendLine();
            sb.AppendLine($"Total: {Total()}");
            sb.AppendLine($"Categorias escolhidas: {Categorias()}");

            return sb.ToString();
        }
    }
}

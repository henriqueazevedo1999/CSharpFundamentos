using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo02
{
    public class Livro
    {
        public string Nome;
        public string Descricao;
        public string Autor;
        public double Preco;

        public Livro()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nome do livro: {Nome}");
            sb.AppendLine($"Descrição livro: {Descricao}");
            sb.AppendLine($"Autor do livro: {Autor}");
            sb.AppendLine($"Preço do livro: {Preco}");

            return sb.ToString();
        }
    }
}

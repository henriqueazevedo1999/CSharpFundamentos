using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Jogo
{
    public class Jogo
    {
        public string Nome;
        public string Categoria;
        public double Preco;

        public Jogo()
        {
        }

        public override string ToString()
        {
            return $"Nome: {Nome} / Categoria: {Categoria} / Preço: {Preco}";
        }
    }
}

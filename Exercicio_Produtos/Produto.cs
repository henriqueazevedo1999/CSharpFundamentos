using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Produtos
{
    public class Produto
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;

                if (value.ToLower() == "bife")
                    _preco = 30.00;
                else if (value.ToLower() == "alcatra")
                    _preco = 45.90;
                else if (value.ToLower() == "costela")
                    _preco = 25.00;
                else if (value.ToLower() == "arroz")
                    _preco = 17.00;
                else if (value.ToLower() == "leite")
                    _preco = 36.00;
            }
        }

        private double _preco;
        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public Produto()
        {
        }
    }
}

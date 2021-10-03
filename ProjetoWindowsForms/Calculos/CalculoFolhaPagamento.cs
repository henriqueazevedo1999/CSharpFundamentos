using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms.Calculos
{
    public class CalculoFolhaPagamento
    {
        public int QuantidadeHoras { get; set; }
        public double ValorHora {get; set;}
        public bool FezCompras {get; set;}
        public bool AuxilioEducacao {get; set;}
        public double ValorCompras {get; set;}

        public double CalcularSalarioBruto()
        {
            return ValorHora * QuantidadeHoras;
        }

        public double CalcularSalarioLiquido()
        {
            double salarioBruto = CalcularSalarioBruto();
            double auxilioEducacao = AuxilioEducacao ? 500 : 0;

            return salarioBruto + auxilioEducacao - ValorCompras;
        }
    }
}

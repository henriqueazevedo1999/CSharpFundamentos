using System.Text;

namespace Exercicio01
{
    public class Operacao
    {
        private double numero1;
        private double numero2;

        public Operacao(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public double Soma()
        {
            return numero1 + numero2;
        }

        public double Subtracao()
        {
            return numero1 - numero2;
        }

        public double Multiplicacao()
        {
            return numero1 * numero2;
        }

        public double Divisao()
        {
            if (numero2 != 0)
                return numero1 / numero2;

            return 0;
        }

        public double Resto()
        {
            return numero1 % numero2;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Soma: {Soma()}");
            sb.AppendLine($"Subtracao: {Subtracao()}");
            sb.AppendLine($"Multiplicacao: {Multiplicacao()}");
            sb.AppendLine($"Divisao: {Divisao()}");
            sb.AppendLine($"Resto: {Resto()}");

            return sb.ToString();
        }
    }
}

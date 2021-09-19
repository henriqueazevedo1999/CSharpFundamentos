using System;

namespace Exemplo_For
{
    public class ExemploFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void ExecutarSolicitacaoInformacao()
        {

        }

        public void ExecutarApresentacaoNumerosDecrescentes()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

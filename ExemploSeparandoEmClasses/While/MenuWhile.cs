using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSeparandoEmClasses.While
{
    public class MenuWhile
    {
        public void Apresentar()
        {
            Console.Clear();

            int opcaoDesejada;

            do
            {
                Console.WriteLine(
                    "1 - Calcular média dos alunos" +
                    "\n2 - Somar números" +
                    "\n99 - Sair");

                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();

                switch (opcaoDesejada)
                {
                    case 1:
                        var calcularMedias = new CalcularMedias();
                        calcularMedias.Executar();
                        break;

                    case 2:
                        var somarNumeros = new SomarNumeros();
                        somarNumeros.Calcular();
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcaoDesejada != 99);
        }
    }
}

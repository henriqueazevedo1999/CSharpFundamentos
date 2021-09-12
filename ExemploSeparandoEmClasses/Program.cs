using ExemploSeparandoEmClasses.Tratamento_Exceção;
using ExemploSeparandoEmClasses.While;
using System;
using Util;

namespace ExemploSeparandoEmClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Principal();

            OpcoesMenu.Principal opcaoEscolhida;

            do
            {
                Console.WriteLine("Digite a opção desejada: ");

                opcaoEscolhida = ConsoleEx.ReadLineAsEnum<OpcoesMenu.Principal>();

                switch (opcaoEscolhida)
                {
                    case OpcoesMenu.Principal.CalcularImc:
                        {
                            var calcularImc = new CalcularImc();
                            calcularImc.Executar();
                            break;
                        }
                    case OpcoesMenu.Principal.CalcularSalarioBrutoELiquido:
                        {
                            var calcularSalario = new CalcularSalarioLiquidoEBruto();
                            calcularSalario.Executar();
                            break;
                        }
                    case OpcoesMenu.Principal.ComprarCurso:
                        {
                            var comprarCurso = new ComprarCurso();
                            comprarCurso.Executar();
                            break;
                        }
                    case OpcoesMenu.Principal.While:
                        {
                            var menu = new MenuWhile();
                            menu.Apresentar();
                            break;
                        }
                    case OpcoesMenu.Principal.TratamentoExcecao:
                        {
                            var menu = new TratamentoExcecao();
                            menu.Executar();
                            break;
                        }
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcaoEscolhida != OpcoesMenu.Principal.Sair);
        }
    }
}

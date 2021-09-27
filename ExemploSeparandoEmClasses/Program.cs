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
            OpcoesMenu.Principal opcaoEscolhida = OpcoesMenu.Principal.Sair;

            do
            {
                Menu.Principal();
                Console.WriteLine("Digite a opção desejada: ");

                opcaoEscolhida = ConsoleEx.ReadLineAsEnum<OpcoesMenu.Principal>();

                switch (opcaoEscolhida)
                {
                    case OpcoesMenu.Principal.Sair:
                        {
                            break;
                        }
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
                    case OpcoesMenu.Principal.For_ExecutarSolicitacaoInformacao:
                        {
                            var menu = new ExemploFor();
                            menu.ExecutarSolicitacaoInformacao();
                            break;
                        }
                    case OpcoesMenu.Principal.For_ApresentarNumerosDecrescentes:
                        {
                            var menu = new ExemploFor();
                            menu.ExecutarApresentacaoNumerosDecrescentes();
                            break;
                        }
                    case OpcoesMenu.Principal.For_ExecutarFatorial:
                        {
                            var menu = new ExemploFor();
                            menu.ExecutarFatorial();
                            break;
                        }
                    case OpcoesMenu.Principal.For_ApresentarRelogio:
                        {
                            var menu = new ExemploFor();
                            menu.ApresentarRelogio();
                            break;
                        }
                    case OpcoesMenu.Principal.For_ExecutarCompraLoja:
                        {
                            var menu = new ExemploFor();
                            menu.ExecutarCompraLoja();
                            break;
                        }
                    case OpcoesMenu.Principal.For_Exemplo2:
                        {
                            var menu = new ExemploFor02();
                            menu.Executar();
                            break;
                        }
                    case OpcoesMenu.Principal.ExemploVetor:
                        {
                            var menu = new Vetor.Vetor();
                            menu.Exemplo04();
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

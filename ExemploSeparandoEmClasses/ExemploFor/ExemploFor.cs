using System;
using System.Text;
using System.Threading;
using Util;

namespace ExemploSeparandoEmClasses
{
    public class ExemploFor
    {
        public void ExecutarSolicitacaoInformacao()
        {
            Console.Clear();

            int quantidadeResideBlumenau = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Olá, você reside em blumenau? (sim/nao)");
                string resposta = Console.ReadLine().ToLower();
                bool resideEmBlumenau = resposta == "sim";

                if (resideEmBlumenau)
                    quantidadeResideBlumenau++;
            }

            Console.Clear();

            Console.WriteLine($"Quantidade de pessoas que residem em Blumenau: {quantidadeResideBlumenau}");

            Thread.Sleep(2000);
        }

        public void ExecutarApresentacaoNumerosDecrescentes()
        {
            Console.Clear();

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{i},");
            }

            Thread.Sleep(2000);
        }

        public void ExecutarFatorial()
        {
            Console.Clear();

            Console.Write("Insira o número que deseja obter o fatorial: ");
            int numero = ConsoleEx.ReadLineAsInt();

            int resultado = 1;

            for (int i = numero; i > 1; i--)
            {
                resultado *= i;
            }

            Console.Clear();

            Console.WriteLine($"O fatorial do número inserido é: {resultado}");

            Thread.Sleep(2000);
        }

        public void ApresentarRelogio()
        {
            for (int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto++)
                {
                    for (int segundo = 0; segundo < 60; segundo++)
                    {
                        //Console.WriteLine(GetHoraFormatada(hora, minuto, segundo));
                        Console.WriteLine(GetHoraFormatada(new TimeSpan(hora, minuto, segundo)));
                    }
                }
            }
        }

        private string GetHoraFormatada(int hora, int minuto, int segundo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(hora.ToString().PadLeft(2, '0'));
            sb.Append(':');

            sb.Append(minuto.ToString().PadLeft(2, '0'));
            sb.Append(':');

            sb.Append(segundo.ToString().PadLeft(2, '0'));

            return sb.ToString();
        }

        private string GetHoraFormatada(TimeSpan time)
        {
            return time.ToString(@"hh\:mm\:ss");
        }

        public void ExecutarCompraLoja()
        {
            Console.Clear();
            Console.WriteLine("Olá, seja bem vindo!");

            OpcoesMenu.Loja opcaoEscolhida = OpcoesMenu.Loja.Sair;
            
            double totalPedido = 0;

            do
            {
                Menu.Loja();

                opcaoEscolhida = ConsoleEx.ReadLineAsEnum<OpcoesMenu.Loja>();

                if (opcaoEscolhida == OpcoesMenu.Loja.Sair)
                    break;

                totalPedido += OpcoesMenu.ValoresItensLoja[opcaoEscolhida];
                
                Console.Clear();

            } while (opcaoEscolhida != OpcoesMenu.Loja.Sair);

            Console.WriteLine($"Valor total do pedido: {totalPedido:C2}");

            Thread.Sleep(2000);
        }
    }
}

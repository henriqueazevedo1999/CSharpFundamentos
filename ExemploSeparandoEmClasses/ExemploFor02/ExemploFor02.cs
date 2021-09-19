using System;
using System.Text;
using System.Threading;
using Util;

namespace ExemploSeparandoEmClasses
{
    public class ExemploFor02
    {
        private PropWithMinMax<string, int> nome = new()
        {
            valor = string.Empty,
            min = 9,
            max = 130
        };

        #region idade
        private PropWithMinMax<int, int> idade = new()
        {
            valor = 0,
            min = 14,
            max = 100
        };
        private int menorIdade = int.MaxValue;
        private int maiorIdade = int.MinValue;
        #endregion

        #region Salario
        private PropWithMinMax<double, double> salario = new()
        {
            valor = 0.0,
            min = 1054,
            max = 99999
        };
        private double mediaSalarios = 0.0;
        private double menorSalario = double.MaxValue;
        private double maiorSalario = double.MinValue;
        private double somaSalarios = 0.0;
        #endregion

        private int quantidadeColaboradores = 0;

        public void Executar()
        {
            Console.Clear();

            SolicitarInformacoes();
            CalcularMediaSalarios();
            ApresentarResultados();

            Thread.Sleep(2000);
        }

        private void ApresentarResultados()
        {
            StringBuilder apresentacao = new();

            apresentacao.AppendLine($"Média dos salários: {mediaSalarios:C2}");
            apresentacao.AppendLine($"Menor salário:      {menorSalario:C2}");
            apresentacao.AppendLine($"Maior salário:      {maiorSalario:C2}");
            apresentacao.AppendLine($"Pessoa mais nova na empresa:  {menorIdade}");
            apresentacao.AppendLine($"Pessoa mais velha na empresa: {maiorIdade}");

            Console.WriteLine(apresentacao.ToString());
        }

        #region Solicitar Informacoes
        private void SolicitarInformacoes()
        {
            Console.Write("Quantos colaboradores serão cadastrados? ");
            int quantidadeColaboradores = ConsoleEx.ReadLineAsInt();

            for (int i = 0; i < quantidadeColaboradores; i++)
            {
                SolicitarNome();
                SolicitarIdade();
                SolicitarSalario();

                ProcessarInformacoes();

                LimparCampos();
                
                Console.Clear();
            }
        }

        private void SolicitarNome()
        {
            bool nomeOk = false;
            do
            {
                Console.Write("Nome: ");
                nome.valor = Console.ReadLine();
                nomeOk = nome.valor.Length >= nome.min && nome.valor.Length <= nome.max;

                if (!nomeOk)
                    Console.WriteLine($"Nome deve ter entre {nome.min} e {nome.max} caracteres.");

            } while (!nomeOk);
        }

        private void SolicitarIdade()
        {
            bool idadeOk = false;
            do
            {
                Console.Write("Idade: ");

                if (!ConsoleEx.ReadLineAsInt(out int valorIdade))
                {
                    Console.WriteLine("Idade fornecida não é um valor válido");
                    continue;
                }

                idade.valor = valorIdade;

                idadeOk = idade.valor >= idade.min && idade.valor <= idade.max;
                if (!idadeOk)
                    Console.WriteLine($"Idade deve ser entre {idade.min} e {idade.max} anos.");

            } while (!idadeOk);
        }

        private void SolicitarSalario()
        {
            bool salarioOk = false;
            do
            {
                Console.Write("Salário: ");
                if (!ConsoleEx.ReadLineAsDouble(out double valorSalario))
                {
                    Console.WriteLine("Salário informado não é um valor válido.");
                    continue;
                }

                salario.valor = valorSalario;

                salarioOk = salario.valor >= salario.min && salario.valor <= salario.max;
                if (!salarioOk)
                    Console.WriteLine($"Salário deve ser um valor entre {salario.min:C2} e {salario.max:C2}.");

            } while (!salarioOk);
        }
        #endregion

        #region Processar Informacoes
        private void ProcessarInformacoes()
        {
            SomarColaborador();
            SomarSalario();
            DefinirMenorIdade();
            DefinirMaiorIdade();
            DefinirMenorSalario();
            DefinirMaiorSalario();
        }

        private void CalcularMediaSalarios()
        {
            try
            {
                mediaSalarios = somaSalarios / quantidadeColaboradores;
            }
            catch (Exception)
            {
                mediaSalarios = 0;
            }
        }

        #endregion

        private void SomarSalario()
        {
            somaSalarios += salario.valor;
        }

        private void SomarColaborador()
        {
            quantidadeColaboradores++;
        }

        private void DefinirMenorIdade()
        {
            if (idade.valor < menorIdade)
                menorIdade = idade.valor;
        }

        private void DefinirMaiorIdade()
        {
            if (idade.valor > maiorIdade)
                maiorIdade = idade.valor;
        }

        private void DefinirMenorSalario()
        {
            if (salario.valor < menorSalario)
            {
                menorSalario = salario.valor;
            }
        }

        private void DefinirMaiorSalario()
        {
            if (salario.valor > maiorSalario)
            {
                maiorSalario = salario.valor;
            }
        }

        private void LimparCampos()
        {
            nome.valor = string.Empty;
            idade.valor = 0;
            salario.valor = 0.0;
        }

        private struct PropWithMinMax<T_valor, T_limites>
        {
            public T_valor valor { get; set; }
            public T_limites min { get; set; }
            public T_limites max { get; set; }
        }
    }
}

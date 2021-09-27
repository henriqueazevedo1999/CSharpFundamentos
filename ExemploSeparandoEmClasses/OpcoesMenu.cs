using System.Collections.Generic;
using System.ComponentModel;

namespace ExemploSeparandoEmClasses
{
    public static class OpcoesMenu
    {
        public enum Principal
        {
            [Description("Sair")]
            Sair = 0,

            [Description("Calcular IMC")]
            CalcularImc,

            [Description("Calcular Salário Bruto e Líquido")]
            CalcularSalarioBrutoELiquido,

            [Description("Comprar Curso")]
            ComprarCurso,

            [Description("While")]
            While,

            [Description("Tratamento de exceção")]
            TratamentoExcecao,

            [Description("For - Executar Solicitação de Informação")]
            For_ExecutarSolicitacaoInformacao,

            [Description("For - Apresentar Números Decrescentes")]
            For_ApresentarNumerosDecrescentes,

            [Description("For - Executar Fatorial")]
            For_ExecutarFatorial,

            [Description("For - Apresentar Relógio")]
            For_ApresentarRelogio,

            [Description("For - Executar Compra Loja")]
            For_ExecutarCompraLoja,

            [Description("For - Exemplo 2")]
            For_Exemplo2,

            [Description("Exemplo vetor")]
            ExemploVetor,
        }

        public enum AreasCursos
        {
            [Description("Sair")]
            Sair = 0,

            [Description("Idiomas")]
            Idiomas,

            [Description("Programação")]
            Programacao,
        }

        public enum CursosIdiomas
        {
            [Description("Sair")]
            Sair = 0,

            [Description("Inglês")]
            Ingles,

            [Description("Alemão")]
            Alemao,

            [Description("Espanhol")]
            Espanhol,
        }

        public enum CursosProgramacao
        {
            [Description("Sair")]
            Sair = 0,

            [Description("C++")]
            CPlusPlus,

            [Description("C#")]
            CSharp,

            [Description("Java")]
            Java,

            [Description("JavaScript")]
            JavaScript,
        }

        public enum Loja
        {
            [Description("Sair")]
            Sair = 0,

            [Description("Jogo do ano R$ 350,00")]
            JogoDoAno,

            [Description("PC master race R$ 14790,00")]
            PCMasterRace,

            [Description("Monitor 120Hz com free sync R$ 2500,20")]
            Monitor120Hz,

            [Description("Cadeira Herman Miller R$ 12000,00")]
            CadeiraHermanMiller,

            [Description("Microfone para live R$ 2500.12")]
            MicrofoneParaLive,
        }

        public static Dictionary<CursosIdiomas, double> ValoresCursosIdiomas = new()
        {
            { CursosIdiomas.Alemao, 275.00 },
            { CursosIdiomas.Espanhol, 260.00 },
            { CursosIdiomas.Ingles, 250.00 }
        };

        public static Dictionary<CursosProgramacao, double> ValoresCursosProgramacao = new()
        {
            { CursosProgramacao.CPlusPlus, 2000 },
            { CursosProgramacao.CSharp, 3000 },
            { CursosProgramacao.Java, 2500 },
            { CursosProgramacao.JavaScript, 1000 },
        };

        public static Dictionary<Loja, double> ValoresItensLoja = new()
        {
            { Loja.JogoDoAno, 350 },
            { Loja.PCMasterRace, 14079 },
            { Loja.Monitor120Hz, 2500.20 },
            { Loja.CadeiraHermanMiller, 12000 },
            { Loja.MicrofoneParaLive, 2500.12 },
        };
    }
}

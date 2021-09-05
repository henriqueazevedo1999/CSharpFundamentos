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
    }
}

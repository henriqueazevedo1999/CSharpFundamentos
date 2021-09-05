using System;

namespace ExemploSeparandoEmClasses
{
    public class ComprarCurso
    {
        private OpcoesMenu.AreasCursos areaEscolhida;

        var cursoEscolhido;

        public void Executar()
        {
            Console.WriteLine("Comprar Curso");

            Menu.AreasCursos();

            areaEscolhida = ConsoleEx.ReadLineAsEnum<OpcoesMenu.AreasCursos>();

            ApresentaCursos();




        }

        private void ApresentaCursos()
        {
            switch (areaEscolhida)
            {
                case OpcoesMenu.AreasCursos.Idiomas:
                    Menu.CursosIdiomas();
                    break;
                case OpcoesMenu.AreasCursos.Programacao:
                    Menu.CursosProgramacao();
                    break;
            }
        }

        public void RealizarPagamento()
        {

        }
    }
}

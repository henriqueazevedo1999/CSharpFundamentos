using System;
using System.Linq;

namespace ExemploSeparandoEmClasses
{
    public static class Menu
    {
        public static void Principal()
        {
            Console.WriteLine("Menu");
            ImprimeOpcoes<OpcoesMenu.Principal>();
        }

        public static void Loja()
        {
            Console.WriteLine("Menu");
            ImprimeOpcoes<OpcoesMenu.Loja>();
        }

        public static void AreasCursos()
        {
            Console.WriteLine("Áreas disponíveis:");
            ImprimeOpcoes<OpcoesMenu.AreasCursos>();
        }

        public static void CursosIdiomas()
        {
            Console.WriteLine("Cursos de idiomas:");
            ImprimeOpcoes<OpcoesMenu.CursosIdiomas>();
        }

        public static void CursosProgramacao()
        {
            Console.WriteLine("Cursos de programação:");
            ImprimeOpcoes<OpcoesMenu.CursosProgramacao>();
        }

        private static void ImprimeOpcoes<T>()
        {
            int maiorOpcao = Enum.GetValues(typeof(T)).Cast<int>().Max().ToString().Length;
            foreach (int opcao in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine($"   {opcao.ToString().PadLeft(maiorOpcao, '0')} - {EnumExtender.GetDescription((Enum)Enum.Parse(typeof(T), opcao.ToString()))}");
            }
        }
    }
}

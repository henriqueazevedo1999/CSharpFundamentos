using System;

namespace ExemploSeparandoEmClasses
{
    public static class Menu
    {
        public static void Principal()
        {
            Console.WriteLine("Menu");
            ImprimeOpcoes<OpcoesMenu.Principal>();
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
            foreach (int opcao in Enum.GetValues(typeof(T)))
            {
                Console.WriteLine($"   {opcao} - {EnumExtender.GetDescription((Enum)Enum.Parse(typeof(T), opcao.ToString()))}");
            }
        }
    }
}

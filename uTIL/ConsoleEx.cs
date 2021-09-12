using System;
using System.Globalization;

namespace Util
{
    public static class ConsoleEx
    {
        public static int ReadLineAsInt(bool emptyAsZero = false)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) && emptyAsZero)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(input);
            }
        }

        public static int ReadLineAsIntExceptionHandling(bool emptyAsZero = false)
        {
            int resultado = 0;
            try
            {
                resultado = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
            }

            return resultado;
        }

        public static double ReadLineAsDouble(bool emptyAsZero = false)
        {
            string input = Console.ReadLine().Replace(',', '.');
            
            if (string.IsNullOrEmpty(input) && emptyAsZero)
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(input, CultureInfo.InvariantCulture);
            }
        }

        public static T ReadLineAsEnum<T>()
        {
            if (typeof(T).IsEnum)
            {
                return (T)Enum.Parse(typeof(T), Console.ReadLine());
            }

            return default;
        }

        public static string ReadLineAsString()
        {
            return Console.ReadLine();
        }
    }
}

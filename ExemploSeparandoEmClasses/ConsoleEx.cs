using System;
using System.Globalization;

namespace ExemploSeparandoEmClasses
{
    public class ConsoleEx
    {
        public static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double ReadLineAsDouble()
        {
            return Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
        }

        public static T ReadLineAsEnum<T>()
        {
            if (typeof(T).IsEnum)
            {
                Enum.Parse(typeof(T), Console.ReadLine());
            }

            return default;
        }

        public static string ReadLineAsString()
        {
            return Console.ReadLine();
        }
    }
}

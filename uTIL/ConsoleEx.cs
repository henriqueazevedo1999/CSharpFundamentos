using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

        public static bool ReadLineAsInt(out int outValue, bool emptyAsZero = false)
        {
            outValue = 0;
            try
            {
                outValue = ReadLineAsInt(emptyAsZero);
                return true;
            }
            catch (Exception)
            {
                return false;
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

        public static bool ReadLineAsDouble(out double outValue, bool emptyAsZero = false)
        {
            outValue = 0.0;
            try
            {
                outValue = ReadLineAsDouble(emptyAsZero);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static T ReadLineAsEnum<T>()
        {
            T resultado = default;

            if (typeof(T).IsEnum)
            {
                try
                {
                    resultado = (T)Enum.Parse(typeof(T), Console.ReadLine());
                }
                catch (Exception)
                {
                }
            }

            return resultado;
        }

        public static string ReadLineAsString()
        {
            return Console.ReadLine();
        }

        public static bool ReadValueWithValidations(out int value, params Func<int, bool>[] validations)
        {
            bool valueOk = ReadLineAsInt(out value);
            if (!valueOk)
                return false;

            foreach (var validation in validations)
            {
                if (!validation(value))
                    return false;
            }

            return true;
        }
    }

    public static class Util
    {
        public static Dictionary<Tkey, Tvalue> GetOrderedDictionary<Tkey, Tvalue>(Dictionary<Tkey, Tvalue> dictionary)
        {
            return dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWindowsForms
{
    public class ConvertEx
    {
        public static bool ToDouble(string text, out double outValue)
        {
            text = text.Trim();
            text = text.Replace('.', ',');

            outValue = 0.0;

            try
            {
                outValue = Convert.ToDouble(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ToInt(string text, out int outValue)
        {
            text = text.Trim();
            text = text.Replace('.', ',');

            outValue = 0;

            try
            {
                outValue = Convert.ToInt32(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public static class StringExtensions
    {
        public static int ToInt(this string texto)
        {
            int temp;
            int.TryParse(texto, out temp);
            return temp;
        }

        public static double ToDouble(this string texto)
        {
            double temp;
            double.TryParse(texto, out temp);
            return temp;
        }

    }
}

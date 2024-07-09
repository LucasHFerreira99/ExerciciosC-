using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStatic
{
    internal class ConversorDeMoeda
    {
        public static double iof = 0.06;

        public static double DolarParaReal(double dolar, double qtd)
        {
            double dolarConvertido = dolar * qtd;
            return dolarConvertido + (dolarConvertido * iof);
        }
    }
}

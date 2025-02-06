using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IDYGS81
{
    public class Menu
    {
        public decimal Suma(decimal num1, decimal num2)
        {
            decimal resultado = num1 + num2;
            return resultado;
        }

        public decimal resta(decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;
            return resultado;
        }

        public decimal multiplicacion(decimal num1, decimal num2)
        {
            decimal resultado = num1 * num2;
            return resultado;
        }

        public decimal division(decimal num1, decimal num2)
        {
            decimal resultado = num1 / num2;
            return resultado;
        }
    }
}

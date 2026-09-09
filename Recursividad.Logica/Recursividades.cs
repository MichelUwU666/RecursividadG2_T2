using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {

            //Caso base o condicion de salida

            if (num == 1)
            {
                return 1;
            }
            //caso general
            return num * CalcularFactorial(num - 1);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        private static string ValidarOPerador(char operador)
        {
            if(char.Equals(operador,'+') || char.Equals(operador, '-') || char.Equals(operador, '*') || char.Equals(operador, '/') ||  )
            {
                return char.ToString(operador);
            }
            else
            {
                return "+";
            }
            
        }

        public static double Operar (Numero num1,Numero num2,string operador)
        {


            return 0;
        }

    }
}

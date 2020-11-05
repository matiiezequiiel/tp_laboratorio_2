using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que sea un operador valido (+,-,*,/)
        /// </summary>
        /// <param name="operador">Operador a validar.</param>
        /// <returns>Retorna el operador validado, si el operador no es valido devuelve '+'</returns>
        private static string ValidarOPerador(char operador)
        {
            if(char.Equals(operador,'+') || char.Equals(operador, '-') || char.Equals(operador, '*') || char.Equals(operador, '/') )
            {
                return char.ToString(operador);
            }
            else
            {
                return "+";
            }
            
        }

        /// <summary>
        /// Gestiona las operaciones llamando a los metodos correspondientes.
        /// </summary>
        /// <param name="num1">Numero 1 a operar.</param>
        /// <param name="num2">Numero 2 a operar.</param>
        /// <param name="operador">Resultado de la operacion elegida.</param>
        /// <returns></returns>
        public static double Operar (Numero num1,Numero num2,string operador)
        {
          
            switch (ValidarOPerador(operador[0]))
            {
                case "+":
                    return num1 + num2;
                    break;
                case "-":
                    return num1 - num2;
                    break;
                case "*":
                    return num1 * num2;
                    break;
                case "/":
                    return num1 / num2;
                    break;
                default:
                    return num1 + num2;
                    break;
            }
            
 
        }

    }
}

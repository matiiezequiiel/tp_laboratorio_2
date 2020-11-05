using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.SetNumero = numero.ToString();
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public string SetNumero
        {
            set { this.numero=ValidarNumero(value) ; }
        }

  

        /// <summary>
        /// Valida cadena para determinar que sea un numero.
        /// </summary>
        /// <param name="strNumero">Cadena a validar.</param>
        /// <returns>Devuelve numero validado, si no es valido devuelve 0.</returns>
        private double ValidarNumero(string strNumero)
        {
            bool isNum;
            double aux=0;

            isNum = double.TryParse(strNumero, out aux);

            if (isNum)
            {
                return aux;
            }
            else
            {
                return aux;
            }

        }

        /// <summary>
        /// Determina si la cadena recibida es binario (1 y 0).
        /// </summary>
        /// <param name="binario">Cadena a determinar si esta en binario.</param>
        /// <returns>True si es binario, false si no es binario.</returns>
        private bool EsBinario(string binario)
        {
            bool retorno=false;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i].Equals('1')||binario[i].Equals('0') )
                {
                    retorno = true;        
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte una cadena en binario a una cadena decimal.
        /// </summary>
        /// <param name="binario">Cadena en binario.</param>
        /// <returns>Cadena en decimal.</returns>
        public string BinarioDecimal(string binario)
        {
            int resultado;

            if (EsBinario(binario))
            {
                resultado = Convert.ToInt32(binario, 2);
                return resultado.ToString();
            }
            else
            {
                return "Valor invalido";
            }
 
        }

        /// <summary>
        /// Convierte un numero decimal a una cadena en binario.
        /// </summary>
        /// <param name="numero">Numero a convertir.</param>
        /// <returns>Cadena en binario.</returns>
        public string DecimalBinario(double numero)
        {
            int numeroEntero;
            numeroEntero = (int)numero;
            String cadena = "";

            numeroEntero =(int) numero;

            if (numero > 0)
            {
                
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                Console.WriteLine(cadena);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    cadena="Nro negativo,error.";
                }
            }

            return cadena;
        }

        /// <summary>
        /// Convierte un numero decimal a una cadena en binario.
        /// </summary>
        /// <param name="numero">Cadena a convertir.</param>
        /// <returns>Cadena en binario.</returns>
        public string DecimalBinario(string numero)
        {
            float numeroConComa;
            int numeroEntero;

            float.TryParse(numero, out numeroConComa);        
            numeroEntero = (int)numeroConComa;

            String cadena = "";

            if (numeroEntero > 0)
            {

                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroEntero = numeroEntero / 2;
                }
                Console.WriteLine(cadena);
            }
            else
            {
                if (numeroEntero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    cadena = "Nro negativo,error.";
                }
            }

            return cadena;
        }

        /// <summary>
        /// Resta de 2 numeros.
        /// </summary>
        /// <param name="n1">Numero 1 a restar.</param>
        /// <param name="n2">Numero 2 a restar.</param>
        /// <returns>Resultado.</returns>
        public static double operator -(Numero n1,Numero n2)
        {
   
            return n1.numero-n2.numero;
        }

        // <summary>
        /// Suma de 2 numeros.
        /// </summary>
        /// <param name="n1">Numero 1 a sumar.</param>
        /// <param name="n2">Numero 2 a sumar.</param>
        /// <returns>Resultado.</returns>
        public static double operator +(Numero n1,Numero n2)
        {
            return n1.numero + n2.numero;
        }

        // <summary>
        /// Multiplicacion de 2 numeros.
        /// </summary>
        /// <param name="n1">Numero 1 a multiplicar.</param>
        /// <param name="n2">Numero 2 a multiplicar.</param>
        /// <returns>Resultado.</returns>
        public static double operator *(Numero n1,Numero n2)
        {
            return n1.numero*n2.numero;
        }

        // <summary>
        /// Division de 2 numeros validando la division por 0.
        /// </summary>
        /// <param name="n1">Numero 1 a dividir.</param>
        /// <param name="n2">Numero 2 a dividir.</param>
        /// <returns>Resultado.</returns>
        public static double operator /(Numero n1,Numero n2)
         {
            if(n2.numero!=0)
            {
                return n1.numero/n2.numero;
            }
            else
            {
                return double.MinValue;
            }
            
        }

    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
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

        public string setNumero
        {
            set{ this.numero = ValidarNumero(value); }
            get { return (this.numero).ToString() ; }
        }

        public string getNumero
        {
            get { return (this.numero).ToString() ; }
        }

        
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
                    cadena="Ingrese solo numeros positivos";
                }
            }

            return cadena;
        }

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
                    cadena = "Ingrese solo numeros positivos";
                }
            }

            return cadena;
        }

        public static double operator -(Numero n1,Numero n2)
        {
   
            return n1.numero-n2.numero;
        }   

        public static double operator +(Numero n1,Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator *(Numero n1,Numero n2)
        {
            return n1.numero*n2.numero;
        } 

        public static double operator /(Numero n1,Numero n2)
         {
            return n1.numero/n2.numero;
        }

    }
}

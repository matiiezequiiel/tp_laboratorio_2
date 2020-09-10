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
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            return "algo";
        }

        public string DecimalBinario(double numero)
        {
            return "algo";
        }

        public string DecimalBinario(string numero)
        {
            return "algo";
        }

        public static double operator -(Numero n1,Numero n2)
        {
            return 0;
        }   

        public static double operator +(Numero n1,Numero n2)
        {
            return 0;
        }

        public static double operator *(Numero n1,Numero n2)
        {
            return 0;
        } 

        public static double operator /(Numero n1,Numero n2)
        {
            return 0;
        }

    }
}

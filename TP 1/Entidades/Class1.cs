using System;
using System.Collections.Generic;
using System.Linq;
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

        

        public double ValidarNumero(string strNumero)
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
    }
}

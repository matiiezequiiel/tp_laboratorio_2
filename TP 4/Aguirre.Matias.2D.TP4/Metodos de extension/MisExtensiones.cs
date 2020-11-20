    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_extension
{
    public static class MisExtensiones
    {
        /// <summary>
        /// Transforma string "si","no","1","0","true","false" en bool. IMPLEMENTACION METODO DE EXTENSION
        /// </summary>
        /// <param name="value">valor a convertir</param>
        /// <returns></returns>
        public static bool ToBoolean(this string value)
        {
            switch (value.ToLower())
            {
                case "true":
                    return true;
                case "si":
                    return true;
                case "1":
                    return true;
                case "0":
                    return false;
                case "false":
                    return false;
                case "no":
                    return false;
                default:
                    throw new InvalidCastException("No se pudo convertir el valor.");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_extension
{
    public static class MisExtensiones
    {
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

        public static string ToCharSexo(this string value)
        {
            switch (value.ToLower())
            {
                case "Masculino":
                    return "M";
                case "Femenino":
                    return "F";
                default:
                    throw new InvalidCastException("No se pudo convertir el valor.");
            }
        }
    }
}

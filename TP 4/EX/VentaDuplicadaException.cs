using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones 
{
    public class VentaDuplicadaException : Exception
    {
        #region Constructores
        /// <summary>
        /// Excepcion que se lanza si hay 2 ventas iguales.
        /// </summary>
        public VentaDuplicadaException() : base("Venta repetida.")
        {

        }

        /// <summary>
        /// Excepcion que controla el formato del DNI sin mensaje
        /// </summary>
        /// <param name="e"> Excepcion </param>
        public VentaDuplicadaException(Exception e) : base(e.ToString())
        {

        }

        /// <summary>
        /// Excepcion que controla el formato del DNI con mensaje recibido como parametro
        /// </summary>
        /// <param name="message"></param>
        public VentaDuplicadaException(string mensaje) : base(mensaje)
        {

        }

      
        #endregion
    }
}

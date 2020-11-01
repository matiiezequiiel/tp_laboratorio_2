using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        #region Constructores
        /// <summary>
        /// Excepcion que controla el DNI si corresponde a su nacionalidad con mensaje
        /// </summary>
        public NacionalidadInvalidaException() : base("La nacionalidad es invalida.")
        {

        }

        /// <summary>
        /// Excepcion que controla el DNI si corresponde a su nacionalidad con mensaje recibido como parametro
        /// </summary>
        /// <param name="message"> Mensaje </param>
        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {

        }

        #endregion

    }
}

using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Cliente : Persona
    {
        #region Atributos
        int nroCliente;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad para numero de cliente.
        /// </summary>
        public int NroCliente
        {
            get { return this.nroCliente; }
            set { this.nroCliente = value; }
        }
        
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor sin parametros para la serializacion.
        /// </summary>
        public Cliente()
        {
           
        }

         /// <summary>
        /// Constructor de instancia sin numero de cliente para subida a BD.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="sexo">Sexo de la persona.</param>
        /// <param name="nacionalidad"> Argentino, Extrajero </param>

        public Cliente(string nombre,string apellido,string dni,ESexo sexo,ENacionalidad nacionalidad) : base(nombre,apellido,dni,sexo,nacionalidad)
        {
            
        }

        /// <summary>
        /// Constructor de instancia con nro de cliente para bajada de BD.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">DNI de la persona.</param>
        /// <param name="sexo">Sexo de la persona.</param>
        /// <param name="nacionalidad"> Argentino, Extrajero </param>
        /// <param name="nroCliente"> Argentino, Extrajero </param>

        public Cliente(string nombre,string apellido,string dni,ESexo sexo,ENacionalidad nacionalidad,int nroCliente) : base(nombre,apellido,dni,sexo,nacionalidad)
        {
            this.nroCliente = nroCliente;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los atributos de el cliente.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nNumero de cliente: {0}",this.nroCliente.ToString());
       
            return sb.ToString();

        }
        #endregion

      
    }
}

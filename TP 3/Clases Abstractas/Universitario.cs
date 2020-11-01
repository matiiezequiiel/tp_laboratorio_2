using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        int legajo;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        public Universitario()
        {
         
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"> Argentino, Extranjero </param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra datos completos de la clase, nombre completo, nacionalidad y su legajo.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.Append("\n");
            sb.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);

            return sb.ToString();
            
        }

        /// <summary>
        /// Implementacion en sus herencias
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Dos universitarios son iguales si tienen el mismo legajo y DNI
        /// </summary>
        /// <param name="pg1"> Universitario 1</param>
        /// <param name="pg2"> Universitario 2</param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;

            if(pg1.legajo == pg2.legajo && pg1.Dni == pg2.Dni)
            {
                retorno=true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Dos universitarios son diferentes si tienen legajo y DNI diferentes
        /// </summary>
        /// <param name="pg1"> Universitario 1</param>
        /// <param name="pg2"> Universitario 2</param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Comprueba si es del mismo tipo
        /// </summary>
        /// <param name="obj"> Cualquiero Clase </param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {            
            return obj is Universitario;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); 
        }

        #endregion
    }
}

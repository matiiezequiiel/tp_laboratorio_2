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

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.Append("\n");
            sb.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);

            return sb.ToString();
            
        }

        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg1.legajo == pg2.legajo && pg1.Dni == pg2.Dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Universitario))
                return false;
            return this == (Universitario)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    sealed public class Alumno : Universitario
    {
        #region Atributos
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }
        
        public Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        public Alumno()
        {
            this.claseQueToma = Universidad.EClases.Laboratorio;
            this.estadoCuenta = EEstadoCuenta.Deudor;
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"> Argentino, Extranjero</param>
        /// <param name="claseQueToma"> Programacion, Laboratorio, Legislacion, SPD </param>
        public Alumno(int id, string nombre, string apelido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apelido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"> Argentino, Extranjero</param>
        /// <param name="claseQueToma"> Programacion, Laboratorio, Legislacion, SPD </param>
        /// <param name="estadoCuenta"> AlDia, Deudor, Becado </param>
        public Alumno(int id, string nombre, string apelido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta) : this(id,nombre,apelido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra datos completos de la clase, nombre completo, nacionalidad, legajo, estado de cuenta y la clase que toma
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }

        /// <summary>
        /// Muestra datos completos de la clase, nombre completo, nacionalidad, legajo y su estado de cuenta
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            sb.AppendFormat( this.ParticiparEnClase());
            
            return sb.ToString();
        }


        /// <summary>
        /// Retorna la clase que toma
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TOMA CLASE DE: {0}", this.claseQueToma);

            return sb.ToString();   
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Un alumno es igual a una clase si su clase es la misma y su estado no es deudor
        /// </summary>
        /// <param name="a"> Alumno </param>
        /// <param name="clase"> Programacion, Laboratorio, Legislacion, SPD</param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;

        }

        /// <summary>
        /// Un alumno es diferente a una clase cuando no esta en ella
        /// </summary>
        /// <param name="a"> Alumno </param>
        /// <param name="clase"> Programacion, Laboratorio, Legislacion, SPD </param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if (a.claseQueToma != clase )
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        #endregion

        #region OVERRIDE DE OBJ Y GET HASH CODE PARA QUE NO DE WARNING

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Alumno;    
        }

        #endregion  


    }
}

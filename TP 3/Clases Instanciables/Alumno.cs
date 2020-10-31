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
        #region atributos
        public Universidad.EClases claseQueToma;
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }

        EEstadoCuenta estadoCuenta;
        #endregion

        #region Constructores
        public Alumno()
        {
            this.claseQueToma = Universidad.EClases.Laboratorio;
            this.estadoCuenta = EEstadoCuenta.Deudor;
        }

        public Alumno(int id, string nombre, string apelido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apelido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apelido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta) : this(id,nombre,apelido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return MostrarDatos();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            sb.AppendFormat( this.ParticiparEnClase());
            
            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TOMA CLASE DE: {0}", this.claseQueToma);

            return sb.ToString();   
        }

        #endregion

        #region Sobrecargas

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


    }
}

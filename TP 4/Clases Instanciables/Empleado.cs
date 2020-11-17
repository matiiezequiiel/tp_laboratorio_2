using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Empleado : Persona
    {
        #region Atributos
        int legajo;
        double sueldo;
        DateTime fechaDeIngreso;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de el atributo legajo.
        /// </summary>
        public int Legajo
        {
            get { return this.legajo; }
           // set { myVar = value; }
        }

        /// <summary>
        /// Propiedad de el atributo sueldo.
        /// </summary>
        public double Sueldo
        {
            get { return this.sueldo; }
           // set { myVar = value; }
        }
        /// <summary>
        /// Propiedad de el atributo fecha de ingreso.
        /// </summary>
        public DateTime FechaIngreso
        {
            get { return this.fechaDeIngreso; }
           // set { myVar = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, instancia una nueva fecha.
        /// </summary>
        public Empleado()
        {
            fechaDeIngreso = new DateTime();
        }
        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre del empleado.</param>
        /// <param name="apellido">Apellido del empleado.</param>
        /// <param name="dni">DNI del empleado.</param>
        /// <param name="sexo">Sexo del empleado.</param>
        /// <param name="nacionalidad"> Argentino, Extrajero </param>
        /// <param name="legajo">Legajo del empleado.</param>
        /// <param name="sueldo">Sueldo del empleado.</param>
        /// <param name="fechaIngreso">Fecha de ingreso del empleado.</param>
        public Empleado(string nombre,string apellido,string dni,ESexo sexo,ENacionalidad nacionalidad,int legajo,double sueldo, DateTime fechaIngreso) : base(nombre,apellido,dni,sexo,nacionalidad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
            this.fechaDeIngreso = fechaIngreso;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muenstra los datos del empleado.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Legajo: {0}\n",this.legajo.ToString());
            sb.AppendFormat("Sueldo: ${0}\n", this.sueldo.ToString());
            sb.AppendFormat("Fecha de ingreso: {0}\n", this.fechaDeIngreso.ToString());

            return sb.ToString();

        }

        /// <summary>
        /// Conversion de bajada de la tabla a Date
        /// </summary>
        /// <param name="aux"></param>
        /// <returns>Sexo de la persona.</returns>
        public static DateTime StringTODate(string aux)
        {
            string[] aux2 = aux.Split(' ');
            string[] fecha = aux2[0].Split('/');
            int[] fechaInt = new int[3];

            for (int i = 0; i < fecha.Length; i++)
            {
                fechaInt[i] = int.Parse(fecha[i]);
            }

           return new DateTime(fechaInt[2], fechaInt[1], fechaInt[0]);
        }
        #endregion



    }
}

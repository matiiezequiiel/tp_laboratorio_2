using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Empleado : Persona
    {
        #region Atributos
        int legajo;
        double sueldo;
        DateTime fechaDeIngreso;
        #endregion

        #region Propiedades
        public int Legajo
        {
            get { return this.legajo; }
           // set { myVar = value; }
        }
        public double Sueldo
        {
            get { return this.sueldo; }
           // set { myVar = value; }
        }
        public DateTime FechaIngreso
        {
            get { return this.fechaDeIngreso; }
           // set { myVar = value; }
        }
        #endregion

        #region Constructores
        public Empleado()
        {
            fechaDeIngreso = new DateTime();
        }
        public Empleado(string nombre,string apellido,string dni,ESexo sexo,ENacionalidad nacionalidad,int legajo,double sueldo, DateTime fechaIngreso) : base(nombre,apellido,dni,sexo,nacionalidad)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
            this.fechaDeIngreso = fechaIngreso;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Legajo: {0}\n",this.legajo.ToString());
            sb.AppendFormat("Sueldo: ${0}\n", this.sueldo.ToString());
            sb.AppendFormat("Fecha de ingreso: {0}\n", this.fechaDeIngreso.ToString());

            return sb.ToString();

        }
        #endregion



    }
}

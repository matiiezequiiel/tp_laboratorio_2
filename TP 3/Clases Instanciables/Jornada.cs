using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Clases_Instanciables
{
    class Jornada
    {
        #region Atributos
        List<Alumno> alumnos;
        Universidad.EClase clase;
        Profesor instructor;


        #endregion

        #region Constructores
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClase clase, Profesor instructor)
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
         
        public Universidad.EClase Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion

        #region Metodos

        public bool Guardar(Jornada jornada)
        {
            return true;
        }

        public string Leer()
        {
            return "algo";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            sb.AppendFormat("CLASE DE: {0} POR {1}",this.clase,this.instructor.ToString());
            sb.AppendLine("\n");
            sb.AppendFormat("Legajo NRO");


            return base.ToString();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            if (a.claseQueToma == j.clase)
            {
                retorno = true;
            }

            return retorno;

        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(!j.alumnos.Contains(a))
            {
                j.alumnos.Add(a);
            }

            return j;
           
        }


        #endregion


    }
}

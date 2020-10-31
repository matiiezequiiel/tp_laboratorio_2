using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Archivos;

namespace Clases_Instanciables
{
    [Serializable]
    public class Jornada
    {
        #region Atributos
        List<Alumno> alumnos;
        Universidad.EClases clase;
        Profesor instructor;
        #endregion

        #region Constructores
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
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
         
        public Universidad.EClases Clase
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

        public static bool Guardar(Jornada jornada)
        {
            Texto auxTexto = new Texto();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            bool retorno = false;

            retorno = auxTexto.Guardar(ruta + @"Jornada.txt", jornada.ToString());

            return retorno;
        }

        public static string Leer(string archivo)
        {
            Texto auxTexto = new Texto();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;

            if (!auxTexto.Leer(ruta + @"Jornada.txt", out string rtnJornada))
            {
                rtnJornada = null;
            }

            return rtnJornada.ToString();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            sb.AppendFormat("CLASE DE: {0} POR {1}\n",this.clase.ToString(),this.instructor.ToString());
            sb.AppendFormat("\nALUMNOS: \n");

            if(alumnos.Count==0)
            {
                sb.AppendLine("No hay alumnos para esta clase.");

            }
            else
            {
                foreach (Alumno item in alumnos)
                {
                    sb.AppendLine(item.ToString());
                }

            }

            sb.AppendLine("<------------------------------------------------------------->");


            return sb.ToString();
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

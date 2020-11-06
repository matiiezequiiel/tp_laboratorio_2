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

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura de la lista privada como atributo alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atriburo privado clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        /// <summary>
        /// propiedad de lectura y escritura del atributo privado instructor
        /// </summary>
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de instancia privado
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="clase"> Programacion, Laboratorio, Legislacion, SPD </param>
        /// <param name="instructor"> Profesor </param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo de clase que guarda en formato .txt Jornada que recibe como parametro
        /// </summary>
        /// <param name="jornada"> Lista del tipo Jornada a guardar</param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto auxTexto = new Texto();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            bool retorno = false;

            retorno = auxTexto.Guardar(ruta + @"Jornada.txt", jornada.ToString());

            return retorno;
        }

        /// <summary>
        /// Metodo de clase que lee un archivo .txt en su directorio
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto auxTexto = new Texto();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;

            if (!auxTexto.Leer(ruta + @"Jornada.txt", out string rtnJornada))
            {
                rtnJornada = null;
            }

            return rtnJornada.ToString();
        }

        /// <summary>
        /// Retorna toda la informacion de la Jornada con todos sus alumnos y su informacion personal
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo de clase, donde una Jornada es igual a un alumno si este pertenece a la clase de esta Jornada
        /// </summary>
        /// <param name="j"> Jornada </param>
        /// <param name="a"> Alumno </param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            if (a.claseQueToma == j.clase)
            {
                retorno = true;
            }

            return retorno;

        }

        /// <summary>
        /// Metodo de clase donde una Jornada no es igual a un alumno si este no este no cursa la clase de la Jornada
        /// </summary>
        /// <param name="j"> Jornada </param>
        /// <param name="a"> Alumno </param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Metodo de clase que a�ade a un alumno a la jornada si este no esta ya en ella
        /// </summary>
        /// <param name="j"> Jornada </param>
        /// <param name="a"> Alumno </param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            bool flag = false;
            foreach (Alumno item in j.Alumnos)
            {
                if (j == a && item == a)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                j.Alumnos.Add(a);
            }
            return j;

        }


        #endregion

        #region OVERRIDE DE OBJ Y GET HASH CODE PARA QUE NO DE WARNING

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Jornada;
        }

        #endregion  



    }
}

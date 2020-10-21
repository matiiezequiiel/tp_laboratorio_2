using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Clases_Instanciables
{
    class Universidad
    {
        #region Atributos
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;
        public enum EClase
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        #endregion

        #region Constructores

        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }

        #endregion

        #region propiedades

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        } 
        public List<Jornada> Jornada
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }  
        
        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public Jornada this[int i]
        {
            get { return this.jornada[i]; }
            set { this.jornada[i] = value; } //VER
        }


        #endregion

        #region Sobrecarga de operadores


        public static bool operator == (Universidad g, Alumno a)
        {
            return true;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g==a);
        }


        public static bool operator ==(Universidad g, Profesor i)
        {
            return true;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


        public static Profesor operator ==(Universidad u, EClase clase)
        {
            return new Profesor();
        }
        public static Profesor operator !=(Universidad u, EClase clase)
        {
            return new Profesor();
        }


        public static Universidad operator +(Universidad g, EClase clase)
        {
            return g;
        }
         
        public static Universidad operator +(Universidad u, Alumno a)
        {
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            return u;
        }



        //VER ESTE METODO QUE ESTA MAL.
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Universidad) || obj.GetType() != typeof(Alumno))
                return false;
            return this == (Universidad)obj; //VER
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion




    }
}

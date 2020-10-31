﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    [Serializable]
    public class Universidad
    {
        #region Atributos
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;
        public enum EClases
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
            get { return this.jornada.ElementAt(i); }
            set { this.jornada.Insert(i,value); } //VER
        }


        #endregion

        #region Metodos

        public static bool Guardar(Universidad datos)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            bool retorno = false;

            XML<Universidad> universidad = new XML<Universidad>();

            retorno = universidad.Guardar(ruta+"XMLUNIVERSIDAD.xml", datos);

            return retorno;
        }

        public static Universidad Leer(string archivo)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
           
            XML<Universidad> universidad = new XML<Universidad>();

            if(!universidad.Leer(ruta + archivo, out Universidad retornoUniversidad))
            {
                retornoUniversidad = null;

            }

            return retornoUniversidad;
        }


        /// <summary>
        /// Muestra los datos de la universidad.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Datos de la universidad.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Jornada item in uni.jornada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

        /// <summary>
        /// Hace publico los datos de la universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }



        #endregion

        #region Sobrecarga de operadores


        /// <summary>
        /// Verifica si el alumno esta inscipto en la universidad
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="a">Alumno</param>
        /// <returns>TRUE si esta inscripto, FALSE si no esta inscripto</returns>
        public static bool operator == (Universidad g, Alumno a)
        {
            bool retorno = false;

            if (g.alumnos.Contains(a))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {   
            return !(g==a);
        }

        /// <summary>
        /// Verifica si el profesor  esta dando clases en la universidad
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="i">Profesor</param>
        /// <returns>TRUE si esta dando clases, FALSE si no esta dando clases</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            if (g.profesores.Contains(i))
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }


        /// <summary>
        /// Retorna el primer profesor que puede dar la clase.
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="clase">Clase</param>
        /// <returns>Profesor que puede dar la clase.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor retorno = null;

            foreach (Profesor item in u.profesores)
            {
                if(item==clase)
                {
                    retorno=item;
                    break;
                }
            }

            if(retorno is null)
            {
                throw new SinProfesorException();
            }

            return retorno;

        }

        /// <summary>
        /// Retorna el primer profesor que no puede dar la clase.
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="clase">Clase</param>
        /// <returns>Profesor que no puede dar la clase.</
        public static Profesor operator !=(Universidad u, EClases clase)
        {

            Profesor retorno = null;

            foreach (Profesor item in u.profesores)
            {
                if (item != clase)
                {
                    retorno = item; //VER LA LOGICA
                }
            }

       
            return retorno;
            
        }


        /// <summary>
        /// Agrega una nueva jornada, indicando la clase y el profesor que puede darla ademas de agregar los alumnos que estan tomando esa clase.
        /// </summary>
        /// <param name="g">Universidad</param>
        /// <param name="clase">Clase</param>
        /// <returns>Universidad</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada=null;
            Profesor profesorAux=null;

            try
            {
                profesorAux = g == clase;
                nuevaJornada = new Jornada(clase, profesorAux);

                foreach (Alumno item in g.alumnos)
                {
                    if (item == clase)
                    {
                        nuevaJornada.Alumnos.Add(item);
                    }
                }

                g.jornada.Add(nuevaJornada);
            }
            catch (Exception e)
            {
                throw new SinProfesorException();
            }
                    
            return g;
        }
         
        /// <summary>
        /// Agrega alumno a la universidad verificando que no esten previamente cargados
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="a">Alumno</param>
        /// <returns>Universidad</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            bool existe = false;
            foreach (Alumno item in u.alumnos)
            {
                if(item.Dni==a.Dni)
                {
                    existe = true;
                    break;
                }
            }

            if(existe)
            {
                throw new AlumnoRepetidoException();
            }
            else
            {
                u.alumnos.Add(a);
            }
            return u;
        }

        /// <summary>
        /// Agrega profesor a la universidad verificando que no esten previamente cargados
        /// </summary>
        /// <param name="u">Universidad</param>
        /// <param name="a">Profesor</param>
        /// <returns>Universidad</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            bool existe = false;
            foreach (Profesor item in u.profesores)
            {
                if (item.Dni == i.Dni)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                u.profesores.Add(i);

            }
    
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

using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_Instanciables
{
    sealed public class Profesor : Universitario
    {
        #region Atributos
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de clase
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Constructor de instancia privado
        /// </summary>
        private Profesor()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            
        }

        /// <summary>
        /// Constructor de instancia 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"> Argentino, Extranjero </param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Profesor().clasesDelDia;           
        }



        #endregion

        #region Metodos

        /// <summary>
        /// Muestra datos completos de la clase. Nombre completo, nacionalidad y su legajo.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
           
            return base.MostrarDatos();

        }

        /// <summary>
        /// Retorna nombre completo, nacionalidad, su legajo y las clases que da por dia
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}CLASES DEL DIA:{1}", this.MostrarDatos(), this.ParticiparEnClase());

            return sb.ToString();
            
        }

        /// <summary>
        /// Retorna nombre completo, su nacionalidad y las dos clases que de ese dia
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendFormat("\n{0}",item);
            }
          

            return sb.ToString();
        }

        /// <summary>
        /// Metodo privado donde asigna dos clases a un instructor
        /// </summary>
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                switch (random.Next(4))                                
                {
                    case 0:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 1:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                    case 2:
                        this.clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 3:
                        this.clasesDelDia.Enqueue(Universidad.EClases.SPD);
                        break;
              
                }


            }
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Un profesor es igual a una clase si este la da en sus dias
        /// </summary>
        /// <param name="i">Profesor</param>
        /// <param name="clase">Clase</param>
        /// <returns>TRUE si el profesor da la  clase, FALSE si no da la clase.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if(clase == item)
                {
                    retorno=true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Un profesor no es igual a una clase si este no la dicta
        /// </summary>
        /// <param name="i"> Profesor </param>
        /// <param name="clase"> Programacion, Laboratorio, Legislacion, SPD </param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion

        #region OVERRIDE DE OBJ Y GET HASH CODE PARA QUE NO DE WARNING

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is Profesor;
        }

        #endregion  

    }
}

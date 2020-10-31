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

        static Profesor()
        {
            Profesor.random = new Random();
        }
        private Profesor()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Profesor().clasesDelDia;           
        }



        #endregion

        #region Metodos

        protected override string MostrarDatos()
        {
           
            return base.MostrarDatos();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //  foreach (Universidad.EClases item in this.clasesDelDia)
            //  {
            //      sb.AppendLine(item.ToString());
            //  }
            sb.AppendFormat("{0}CLASES DEL DIA:{1}", this.MostrarDatos(), this.ParticiparEnClase());
            return sb.ToString();
            
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendFormat("\n{0}",item);
            }
          

            return sb.ToString();
        }

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
        /// Verifica si el profesor da la clase
        /// </summary>
        /// <param name="i">Profesor</param>
        /// <param name="clase">Clase</param>
        /// <returns>TRUE si el profesor da la clase, FALSE si no da la clase.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if(clase == item)
                {
                    retorno=true;
                }
            }
            return retorno;
        }


        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion


    }
}

using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_Instanciables
{
    sealed class Profesor : Universitario
    {
        #region Atributos
        Queue<Universidad.EClase> clasesDeldia;
        static Random random;
        #endregion

        #region Constructores
       
        private Profesor()
        {
            random = new Random();
            clasesDeldia = new Queue<Universidad.EClase>();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id,nombre,apellido,dni,nacionalidad)
        {
            _randomClases();             
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
            sb.AppendLine(MostrarDatos());
            sb.AppendLine(ParticiparEnClase());

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClase item in this.clasesDeldia)
            {
                sb.Append(item);
            }
          

            return sb.ToString();
        }

        private void _randomClases()
        {
            Universidad.EClase claseRandom1 = (Universidad.EClase)random.Next(0, 4);
            Universidad.EClase claseRandom2 = (Universidad.EClase)random.Next(0, 4);

            this.clasesDeldia.Enqueue(claseRandom1);
            this.clasesDeldia.Enqueue(claseRandom2);
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Profesor i, Universidad.EClase clase)
        {
            bool retorno = false;
            foreach (Universidad.EClase item in i.clasesDeldia)
            {
                if(clase == item)
                {
                    retorno=true;
                }
            }
            return retorno;
        }
        
        public static bool operator !=(Profesor i, Universidad.EClase clase)
        {
            return !(i == clase);
        }

        #endregion


    }
}

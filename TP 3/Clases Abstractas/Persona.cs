using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.XPath;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region Atributos
        string nombre;
        string apellido;
        int dni;
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        ENacionalidad nacionalidad;

        #endregion

        #region Constructores

        public Persona()
        {
            

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            StringToDNI = dni;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            Dni = dni;
        }


        #endregion

        #region Propiedades

       
        public string Nombre
        {
            get { return this.nombre; }
            set {
                    string nombre = ValidarNombreApellido(value);
                    
                    if(nombre != null)
                    {
                         this.nombre = nombre;
                    }
               
                }
        }

     
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                    string apellido = ValidarNombreApellido(value);

                    if (apellido != null)
                    {
                        this.apellido = apellido;
                    }
            }

        }
        
        /// <summary>
        /// Valida si el dni se encuentra entre los valores correspondondientes a la nacionalidad indicada, de lo contrario lanza una excepcion-
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
            set {
                    try
                    {
                        int dni = ValidarDni(this.nacionalidad, value);

                        if (dni != -1)
                        {
                            this.dni = dni;
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                   

            }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// Convierte cadena a entero y valida que el numero este dentro del rango 1/99999999 que es el permitido para un dni.
        /// </summary>
        public string StringToDNI
        {
            //PASAR STRING A ENTERO VALIDANDOLO
            set {
                    try
                    {
                        int dni = ValidarDni(this.nacionalidad, value);

                        if (dni != -1)
                        {
                            this.dni = dni;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                   
                }
        }


        #endregion

        #region Metodos

        /// <summary>
        /// Valida dni del tipo int si esta dentro de los rangos para cada nacionalidad.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad </param>
        /// <param name="dato">Dni a validar.</param>
        /// <returns>Retorna el dni validado si esta correcto, -1 si es incorrecto.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if(dato>0 && dato < 1000000000)
            {
                if (this.nacionalidad == ENacionalidad.Argentino && dato > 1 && dato < 89999999)
                {
                    return dato;
                }
                else if (this.nacionalidad == ENacionalidad.Extranjero && dato > 90000000 && dato < 99999999)
                {
                    return dato;
                }
                else
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no condice con el numero de DNI.");
                }

            }
            else
            {
                throw new DniInvalidoException("El DNI no tiene un formato valido.");
            }
            
           
        }

        /// <summary>
        /// Valida dni del tipo string si esta dentro de los rangos para cada nacionalidad.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad </param>
        /// <param name="dato">Dni a validar.</param>
        /// <returns>Retorna el dni validado si esta correcto, -1 si es incorrecto.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int numero;

            if(int.TryParse(dato,out numero) && numero > 0 && numero < 1000000000)
            {

                if (this.nacionalidad == ENacionalidad.Argentino && numero > 1 && numero < 89999999)
                {
                    return numero;
                }
                else if (this.nacionalidad == ENacionalidad.Extranjero && numero > 90000000 && numero < 99999999)
                {
                    return numero;
                }
                else
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no condice con el numero de DNI.");

                }
            }
            else
            {
                throw new DniInvalidoException("El DNI no tiene un formato valido.");
            
            }


        }

        /// <summary>
        /// Valida que el nombre no tenga espacios, numeros o simbolos.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Nombre o apellido si es correcto, NULL si es invalido.</returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = null;

            for (int i = 0; i < dato.Length; i++)
            {
                if (char.IsWhiteSpace(dato[i]) || char.IsNumber(dato[i]) || char.IsSymbol(dato[i]))
                {
                    break;
                }
                else
                {
                   retorno = dato;
                }
            }

            return retorno;

        }


        /// <summary>
        /// Muestra los datos de la persona.
        /// </summary>
        /// <returns>String con todos los datos de la persona.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1} \n", this.apellido,this.nombre);
            sb.AppendFormat("NACIONALIDAD: {0}", this.nacionalidad);
          

            return sb.ToString();
        }

        #endregion

    }
}

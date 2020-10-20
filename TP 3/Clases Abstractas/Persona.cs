using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        #region Propiedades

        /// <summary>
        /// Valida que el nombre no tenga espacios, numeros o simbolos.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if(char.IsWhiteSpace(value[i]) || char.IsNumber(value[i]) || char.IsSymbol(value[i]))
                        {
                             break;
                        }
                        else
                        {
                             this.nombre = value;

                        }
                    }
               
                }
        }

        /// <summary>
        /// Valida que el apellido no tenga espacios, numeros o simbolos.
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsWhiteSpace(value[i]) || char.IsNumber(value[i]) || char.IsSymbol(value[i]))
                    {
                        break;
                    }
                    else
                    {
                        this.apellido = value;

                    }
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
                    if(this.nacionalidad==ENacionalidad.Argentino && value>1 && value < 89999999)
                    {
                        this.dni = value;
                    }
                    else if(this.nacionalidad==ENacionalidad.Extranjero && value> 90000000 && value < 99999999 )
                    {
                        this.dni = value;
                    }
                    else
                    {
                        //throw NacionalidadInvalidaException.
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
                    int numero;
                    if(int.TryParse(value,out numero) && numero>1 && numero< 99999999)
                    {
                         this.Dni = numero;                  
                    }
                    else
                    {
                        //throw DniInvalidoException
                    }

                }
        }
        

        #endregion






    }
}

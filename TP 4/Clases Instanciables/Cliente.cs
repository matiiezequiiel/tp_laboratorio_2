using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Cliente : Persona
    {
        #region Atributos
        int nroCliente;
        #endregion

        #region Propiedades
        public int NroCliente
        {
            get { return this.nroCliente; }
            // set { myVar = value; }
        }
        
        #endregion

        #region Constructores
        public Cliente()
        {
           
        }
        public Cliente(string nombre,string apellido,string dni,ESexo sexo,ENacionalidad nacionalidad,int nroCliente) : base(nombre,apellido,dni,sexo,nacionalidad)
        {
            this.nroCliente = nroCliente;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.AppendFormat("\nNumero de cliente: {0}",this.nroCliente.ToString());
       
            return sb.ToString();

        }
        #endregion

      
    }
}

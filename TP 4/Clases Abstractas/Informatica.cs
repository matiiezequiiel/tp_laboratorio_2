﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases_Abstractas
{
    [Serializable]
    [XmlInclude(typeof(Clases_Instanciables.Celular))]
    [XmlInclude(typeof(Clases_Instanciables.Computadora))]
    public abstract class Informatica : Producto
    {

        #region Atributos
        protected int memoriaRam;
        protected int almacenamiento;
        #endregion

        #region Propiedades
        public int MemoriaRam
        {
            get { return this.memoriaRam; }
            set { this.memoriaRam = value; }
        }
        public int Almacenamiento
        {
            get { return this.almacenamiento; }
            set { this.almacenamiento = value; }
        }

        #endregion

        #region Constructores

        public Informatica()
        {

        }

        public Informatica(string nombre, string codigo, double precio, int stock, int memoriaRam, int almacenamiento) : base(nombre,codigo,precio,stock)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
        } 
        
        public Informatica(string nombre, double precio, int stock, int memoriaRam, int almacenamiento) : base(nombre,precio,stock)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Memoria RAM: {0} GB\n",this.memoriaRam.ToString());
            sb.AppendFormat("Almacenamiento: {0} GB\n", this.almacenamiento.ToString());

            return sb.ToString();
        }
        #endregion
    }
}

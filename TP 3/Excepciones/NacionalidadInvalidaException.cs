﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException() : base("La nacionalidad es invalida.")
        {

        }
        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {

        }
    }
}

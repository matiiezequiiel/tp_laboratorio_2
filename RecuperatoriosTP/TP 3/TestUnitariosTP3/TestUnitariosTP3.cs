using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Abstractas;
using Clases_Instanciables;
using Excepciones;

namespace TestUnitariosTP3
{
    [TestClass]
    public class TestUnitariosTP3
    {
        #region TEST UNITARIOS
        /// <summary>
        /// Metodo de test que comprueba alumno repetido y genera una excepcion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void Test_AlumnoRepetido()
        {              

            Alumno a1 = new Alumno(1, "Matias", "Aguirre", "90000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(1, "Matias", "Aguirre", "90000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
          
            Universidad u = new Universidad();

            
            u += a1;
            u += a2;
                
           

        }

        /// <summary>
        /// Metodo de test que valida rando de DNI dependiendo de su nacionalidad y genera una excepcion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void Test_DNINacionalidadInvalida()
        {
            string DNI_Invalido= "90000000";   // 90.000.000 A 99.999.999 | DNI FUERA DE RANGO EN ALUMNO a1

            Alumno a1 = new Alumno(1, "Matias", "Aguirre", DNI_Invalido, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(2, "Federico", "Ramirez", "95000000", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Universidad u = new Universidad();
            
            u += a1;
            u += a2;
           
        }

        /// <summary>
        /// Metodo de test que valida el formato numerico para la carga del DNI
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void Test_DNIValorNumerico()
        {
            string DNI_MalFormato = "90000D00";  

            Alumno a1 = new Alumno(1, "Matias", "Aguirre", DNI_MalFormato, Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            Universidad u = new Universidad();

            u += a1;

        }

        /// <summary>
        /// Metodo de test que valida un tpo de clase si su valor es NULL
        /// </summary>
        [TestMethod]

        public void Test_ValorNull()
        {
            Universidad u = new Universidad();
           
            Assert.IsNotNull(u.Alumnos);
            Assert.IsNotNull(u.Instructores);
            Assert.IsNotNull(u.Jornada);
         
        }
        #endregion
    }
}

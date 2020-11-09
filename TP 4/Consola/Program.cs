using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Instanciables;
using Clases_Abstractas;

namespace Consola
{
    class Test
    {
        static void Main(string[] args)
        {
            #region Hardcodeo de objetos
            Cliente c1 = new Cliente("Juan", "Carlos", "465127844", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 1);
            Cliente c2 = new Cliente("Marcos", "Gonzalez", "465127745", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 2);
            Cliente c3 = new Cliente("Ruben", "Martinez", "95123456", Persona.ESexo.Masculino, Persona.ENacionalidad.Extranjero, 3);
            Cliente c4 = new Cliente("Claudia", "Garcia", "465127545", Persona.ESexo.Femenino, Persona.ENacionalidad.Argentino, 4);
            Cliente c5 = new Cliente("Ezequiel", "Ramirez", "465127487", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 5);
            Cliente c6 = new Cliente("Maria", "Gaitan", "465127398", Persona.ESexo.Femenino, Persona.ENacionalidad.Argentino, 6);

            Empleado e1 = new Empleado("Marcos", "Acuña", "45689784", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 1, 45000, new DateTime(2020, 05, 17));
            Empleado e2 = new Empleado("Karina", "Fernandez", "95666485", Persona.ESexo.Femenino, Persona.ENacionalidad.Extranjero, 1, 40000, new DateTime(2020, 01, 17));
            
            Empleado e3 = new Empleado("Miguel", "Palermo", "45689878", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 1, 45000, new DateTime(2020, 02, 27));

            Computadora pc1 = new Computadora("Lenovo 4578", 200000.99, 10, 16, 240, true, true);
            Computadora pc2 = new Computadora("Dell 5000", 250000.99, 5, 8, 120, true, false);
            Computadora pc3 = new Computadora("HP M4", 180000, 20, 4, 120, false, false);
            Computadora pc4 = new Computadora("Asus 8000", 3000000, 3, 32, 480, true, true);
            Computadora pc5 = new Computadora("MSI 1234", 100000, 20, 16, 120, false, true);
            
            Celular cel1 = new Celular("Samsung 4578", 10000, 10, 16, 240, true, 8);
            Celular cel2 = new Celular("Nokia 1100", 15000, 5, 8, 120, true, 10);
            Celular cel3 = new Celular("Motorola C115", 18000, 20, 4, 120, false, 9);
            Celular cel4 = new Celular("Motrola V3", 20000, 3, 32, 480, true, 5);
            Celular cel5 = new Celular("Xiamo 1234", 40000, 20, 16, 120, false, 9);

            Electrodomesticos electro1 = new Electrodomesticos("Licuadora", 5000, 50,800, true, Electrodomesticos.ECategoria.Cocina);
            Electrodomesticos electro2 = new Electrodomesticos("Ventilador", 8000, 20 ,1600, false, Electrodomesticos.ECategoria.Ventilacion);
            Electrodomesticos electro3 = new Electrodomesticos("Heladera", 10000, 10, 3200, false, Electrodomesticos.ECategoria.Refrigeracion);

            #endregion





        }
    }
}

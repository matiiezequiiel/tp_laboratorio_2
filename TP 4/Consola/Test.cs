using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Instanciables;
using Clases_Abstractas;
using Excepciones;

namespace Consola
{
    class Test
    {
        static void Main(string[] args)
        {
            #region Hardcodeo de objetos

            Comercio miComercio = new Comercio();

            Cliente c3 = new Cliente("Ruben", "Martinez", "95123453", Persona.ESexo.Masculino, Persona.ENacionalidad.Extranjero, 3);
            Cliente c4 = new Cliente("Claudia", "Garcia", "46512754", Persona.ESexo.Femenino, Persona.ENacionalidad.Argentino, 4);
            Cliente c5 = new Cliente("Ezequiel", "Ramirez", "46512748", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 5);
            Cliente c6 = new Cliente("Maria", "Gaitan", "46512739", Persona.ESexo.Femenino, Persona.ENacionalidad.Argentino, 6);

            Empleado e1 = new Empleado("Marcos", "Acuña", "45689785", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 1, 45000, new DateTime(2020, 05, 17));
            Empleado e2 = new Empleado("Karina", "Fernandez", "95666483", Persona.ESexo.Femenino, Persona.ENacionalidad.Extranjero, 2, 40000, new DateTime(2020, 01, 17));
            
            Empleado e3 = new Empleado("Miguel", "Palermo", "45689878", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 3, 45000, new DateTime(2020, 02, 27));

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

            #region PRUEBO EXCEPCION DNI INVALIDO Y NACIONALIDAD INVALIDA
            try
            {
                //NACIONALIDAD INVALIDA
                Cliente c1 = new Cliente("Juan", "Carlos", "95000000", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 1);
                
            }
            catch (NacionalidadInvalidaException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                //DNI INVALIDO
                Cliente c2 = new Cliente("Marcos", "Gonzalez", "4651H774", Persona.ESexo.Masculino, Persona.ENacionalidad.Argentino, 2);
            }
            catch (DniInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }


            #endregion


            #region Agrego Clientes

            //miComercio += c1;
           // miComercio += c2;
            miComercio += c3;
            miComercio += c4;
            miComercio += c5;
            miComercio += c6;

            #endregion


            #region Agrego Empleados

            miComercio += e1;
            miComercio += e2;
            miComercio += e3;

            #endregion


            #region Agrego Productos

            miComercio += pc1;
            miComercio += cel1;
            miComercio += pc2;
            miComercio += cel2;
            miComercio += pc3;
            miComercio += cel3;
            miComercio += pc4;
            miComercio += cel4;
            miComercio += pc5;
            miComercio += cel5;
            miComercio += electro1;
            miComercio += electro2;
            miComercio += electro3;

            #endregion


            #region Agrego Ventas
            List<Producto> lp1 = new List<Producto>();
            List<Producto> lp2 = new List<Producto>();
            List<Producto> lp3 = new List<Producto>();
            lp1.Add(cel4);
            lp1.Add(electro2);

            lp2.Add(pc2);
            lp2.Add(electro3);
            lp2.Add(cel2);

            lp3.Add(cel1);
            lp3.Add(pc3);
            lp3.Add(cel3);
            lp3.Add(electro3);

            Venta venta1 = new Venta(lp1, 1, c4, e1);
            Venta venta2 = new Venta(lp2, 2, c3, e2);
            Venta venta3 = new Venta(lp3, 1, c5, e3);

            miComercio += venta1;
            miComercio += venta2;
           
            //PRUEBO EXCEPCION VENTA REPETIDA(MISMO NRO DE TICKET)
            try
            {
                miComercio += venta3;
            }
            catch (VentaDuplicadaException e)
            {
                Console.WriteLine(e.Message);
          
            }
            

            #endregion

            #region Muestro datos cargados

            Console.WriteLine(miComercio.ToString()); 
            Console.ReadKey();
            #endregion



        }
    }
}

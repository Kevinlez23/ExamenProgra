using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class menu
    {
        //menu principal
        public static void principal()
        {
            int opcion = 0;

            do
            {

                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Agregar Empleados");
                Console.WriteLine("3- Modificar Empleados");
                Console.WriteLine("4- Borrar Empleados");
                Console.WriteLine("5- Reportes");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1: Empleados.inicializarArreglos(); break;
                    case 2: Empleados.ingresarEmpleado(); break;
                    case 3: Empleados.modificarEmpleado(); break;
                    case 4: Empleados.eliminarEmpleado(); break;
                    case 5: Empleados.Reportes(); break;
                    case 6: Console.WriteLine("Saliendo del sistema"); break;
                    default: Console.WriteLine("*** opcion incorrecta *** "); break;
                }

            } while (opcion != 6);    
        }

    }
}

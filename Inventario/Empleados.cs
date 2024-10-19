using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{


    internal class Empleados
    {

        public static int[] id = new int[2]; 
        public static string[] nombre = new string[2]; 
        public static int[] Telefono = new int[2]; 
        public static int[] Salario = new int[2]; 
        public static string[] Direccion = new string[2];

        //metodo para inicializar arreglos
        public static void inicializarArreglos() 
        {

            for (int i = 0; i < id.Length; i++) 
            {
                id[i] = 0;
                nombre[i] = "";
                Telefono[i] = 0;
                Salario[i] = 0;
                Direccion[i] = "";
            
            
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();


        }




      
        public static void ingresarEmpleado()
        {
            int indice = 0;
            while (indice < id.Length)
            {
                Console.WriteLine("Digite la cedula: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Agregue un Empleado: ");
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite el numero de telefono: ");
                Telefono[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el Salario: ");
                Salario[indice] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la direccion del empleado: ");
                Direccion[indice] = Console.ReadLine();
                indice++;
                Console.Clear();

            }
            Console.WriteLine("El empleado ha sido agregado");
        }


 
        public static void modificarEmpleado() 
        {
            Console.Clear();
            Console.WriteLine("digite la cedula del empleado que desea modificar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i]) 
                {
                    Console.WriteLine($"cedula: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine($"Telefono: {Telefono[i]} Salario: {Salario[i]}");
                    Console.WriteLine($"Direccion de empleado: {Direccion[i]} ");
                    Console.WriteLine($"**************************************");
                    Console.WriteLine("Digite un nuevo nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite un nuevo Telefono: ");
                    Telefono[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el nuevo salario: ");
                    Salario[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite una nueva direcion: ");
                    Direccion[i] = Console.ReadLine();
                    break;
                }


                
            }
            
        }

        public static void Reportes() 
        {
            int opcion = 0;

            do
            {

                Console.WriteLine("1- Constultar empleado por numero de cedula");
                Console.WriteLine("2- Constultar lista de empleados");
                Console.WriteLine("3- Promedio de salarios");
                Console.WriteLine("4- Volver al menu");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1: Empleados.consultarCedula(); break;
                    case 2: Empleados.consultarEmpleados(); break;
                    case 3: Empleados.promedioSalario(); break;
                    case 4: Console.WriteLine("Saliendo del sistema"); break;
                    default: Console.WriteLine("*** opcion incorrecta *** "); break;
                }

            } while (opcion != 4);
        }
        public static void consultarCedula()
        {
            Console.Clear();
            Console.WriteLine("digite la cedula del empleado que desea ver: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"cedula: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine($"Telefono: {Telefono[i]} Salario: {Salario[i]}");
                    Console.WriteLine($"Direccion de empleado: {Direccion[i]} ");
                    Console.WriteLine($"**************************************");
                    
                }

            }

        }


  
        public static void consultarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("*** REPORTE DE EMPLEADOS ***");
            for (int i = 0; i < id.Length; i++)   
            {
                Console.WriteLine($"Cedula: {id[i]} Nombre: {nombre[i]}");
                Console.WriteLine($"Telefono: {Telefono[i]} Salario: {Salario[i]}");
                Console.WriteLine($"Direccion de empleado: {Direccion[i]} ");
                Console.WriteLine($"**************************************");

            }
            Console.WriteLine("*** FIN DEL REPORTE ***");

        }


        public static void promedioSalario()
        {
            Console.Clear();
            double sumaSalarios = 0;
            for (int i = 0; i < Salario.Length; i++)
            {
                sumaSalarios += Salario[i];
            }

            double promedioSalario = sumaSalarios / Salario.Length;
            Console.WriteLine($"El promedio de los salarios es: {promedioSalario}");
        }



        public static void eliminarEmpleado() 
        {
            Console.Clear();
            Console.WriteLine("digite la cedula del empleado que desea eliminar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"Cedula: {id[i]} Nombre: {nombre[i]}");
                    Console.WriteLine("Empleado eliminado");
                    nombre[i] = "";
                    id[i] = 0;
                    Telefono[i] = 0;
                    Salario[i] = 0;
                    Direccion[i] = "";
                    break;
                }
            }

        }


    }
}

using System;
using System.Linq;


namespace Ejercicio_3
{
    internal class Program
    {

        public static void Extrados()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine(" █▀▀ ▀▄▀ ▀█▀ █▀█ ▄▀█ █▀▄ █▀█ █▀");
            Console.WriteLine(" ██▄ █░█ ░█░ █▀▄ █▀█ █▄▀ █▄█ ▄█    {version 1.0}");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void Menu()
        {
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("|       1. Agregar personal        |");
            Console.WriteLine("|       2. Eliminar personal       |");
            Console.WriteLine("|       3. Buscar personal         |");
            Console.WriteLine("|       4. Listar personal         |");
            Console.WriteLine("|       5. Salir                   |");
            Console.WriteLine("+----------------------------------+");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|   Elige una de las opciones:     |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+----------------------------------+");

        }

        public static void MenuAgregar()
        {
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine("|          1. Agregar Empleado                |");
            Console.WriteLine("|          2. Agregar Supervisor              |");
            Console.WriteLine("|          3. Agregar Encargado               |");
            Console.WriteLine("|          4. Salir de Agregar                |");
            Console.WriteLine("+---------------------------------------------+");
        }

        static void Main(string[] args)
        {

            int ID = 100;
            JavierList list = new JavierList(3);

            bool salir = false;
            int a = 0;

            while (!salir)
            {
                if (a == 0)
                {
                    Extrados();
                    a = ++a;
                }
                Menu();

                try
                {
                    int opcion = Int32.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("|      Has elegido la opción 1     AGREGAR    |");
                            Console.WriteLine("-----------------------------------------------");

                            MenuAgregar();

                            int opcion2 = Convert.ToInt32(Console.ReadLine());

                            switch (opcion2)
                            {
                                case 1:
                                    ID++;
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese el nombre del empleado:                ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    string nombre = Console.ReadLine();
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese la fecha de nacimiento del empleado:   ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    string fecha = Console.ReadLine();
                                    Empleado empleado = new Empleado(ID, nombre, fecha);
                                    list.Agregar(empleado);
                                    
                                    break;
                                case 2:
                                    ID++;
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese el nombre del supervisor: ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese la fecha de nacimiento del supervisor: ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    fecha = Console.ReadLine();
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese el número de empleados a cargo: ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    int empleadosACargo = int.Parse(Console.ReadLine());
                                    Empleado supervisor = new Supervisor(ID, nombre, fecha,empleadosACargo);
                                    list.Agregar(supervisor);
                                    
                                    break;
                                case 3:
                                    ID++;
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese el nombre del encargado:               ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese la fecha de nacimiento del encargado:  ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    fecha = Console.ReadLine();
                                    Console.WriteLine("+---------------------------------------------+");
                                    Console.WriteLine("Ingrese el número de sucursales a cargo:       ");
                                    Console.WriteLine("+---------------------------------------------+");
                                    int sucursalesACargo = int.Parse(Console.ReadLine());
                                    Empleado encargado1 = new Encargado(ID, nombre,fecha, sucursalesACargo);
                                    list.Agregar(encargado1);
                                    
                                    break;
                                case 4:
                                    
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Ingrese un valor entre 1 y 4");
                                    
                                    break;

                            }

                        break;

                        case 2:
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("|      Has elegido la opción 2     ELIMINAR        |");
                            Console.WriteLine("----------------------------------------------------");
                            
                            Console.WriteLine("Ingrese el ID del personal que desea eliminar:      ");
                            Console.WriteLine("+--------------------------------------------------+");
                            int borrarId = int.Parse(Console.ReadLine());
                            string resultadoEliminar = list.Eliminar(borrarId);
                            Console.WriteLine(resultadoEliminar);
                            
                            break;

                        case 3:
                        Console.WriteLine("+------------------------------------------------------+");
                        Console.WriteLine("|         Has elegido la opción 3     BUSCAR           |");
                        Console.WriteLine("+------------------------------------------------------+");
                        
                        Console.WriteLine("|Ingrese el nombre que desea buscar:                    ");
                        Console.WriteLine("+------------------------------------------------------+");
                        string nombreB = Console.ReadLine();
                        string result = list.Buscar(nombreB);
                        Console.WriteLine(result);

                        break;

                        case 4:
                            Console.WriteLine("+-------------------------------------------------+");
                            Console.WriteLine("|        Has elegido la opción 4   LISTAR         |");
                            Console.WriteLine("+-------------------------------------------------+");
                            list.MostrarLista();
                            
                        break;
                        case 5:

                            Console.WriteLine("SAlIR");
                            salir = true;

                            break;
                       
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("|  ERROR !! Elige una opcion entre 1 y 5  |");
                            Console.WriteLine("-------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.White;

                            break;


                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("|     ERROR Ingrese un número valido.     |");
                    Console.WriteLine("-------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }





            }

        }
    }
}

using System;
using System.Linq;

namespace Ejercicio_3
{
	internal class JavierList
	{

		Empleado [] datos;
		int contadorArreglo;
        int tamanioArreglo;

        public JavierList(int tamanio)
		{
            
            datos = new Empleado[tamanio];
            tamanioArreglo = tamanio;
            contadorArreglo = 0;
		}

		private void DuplicarTamanoArray(Empleado valorAgregar)
		{
            int n2 = tamanioArreglo * 2;
            Empleado[] newArreglo = new Empleado[n2];

            for (int i = 0; i < tamanioArreglo; i++)
            {
                newArreglo[i] = datos[i];
            }
            tamanioArreglo = n2;           
            datos = newArreglo;    
            Agregar(valorAgregar);             
		}

		public void Agregar(Empleado valorAgregar)
		{

			if (contadorArreglo <= tamanioArreglo - 1)
			{
				//inserto el valor
				datos[contadorArreglo] = valorAgregar;
				contadorArreglo++;
			}
			else
			{
				DuplicarTamanoArray(valorAgregar);
			}

		}

        public void MostrarLista()
        {
            Console.WriteLine("+--------------------------------------------------------------------------------------");
            foreach (Empleado e in datos)
            {
                if (e != null)
                    
                    Console.Write(e.Mostrar());
                
            }
            Console.WriteLine("+--------------------------------------------------------------------------------------");
        }

        public  string Buscar(string nombreBuscado)
        {

            for (int i = 0; i < contadorArreglo; i++)
            {
                if (datos[i].Nombre == nombreBuscado)
                {
                    return "| ID     " + datos[i].ID + " / Nombre   " + datos[i].Nombre + "/ Fecha de Nacimiento:   " + datos[i].FechaNacimiento;  
                }
            }
            return "No existe el empleado buscado";
        } 

        public string Eliminar(int numeroID)
        {

            for (int i = 0; i < contadorArreglo; i++)
            {
                if (datos[i].ID == numeroID)
                {
                    datos = datos.Where(val => val != datos[i]).ToArray();
                    return " El personal ID   " + numeroID  + " ha sido eliminado" ; 
                }
            }
            contadorArreglo--;
            return "No existe el empleado que intenta eliminar";
        }

    }
}
					


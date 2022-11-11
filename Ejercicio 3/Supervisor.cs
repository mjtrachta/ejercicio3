using System;
using System.Linq;


namespace Ejercicio_3
{
    internal class Supervisor:Empleado
    {
        //propiedades
        public int EmpleadosACargo { get; set; }

        //constructor por defecto
        public Supervisor()
        {

        }

        // constructores 
        public Supervisor(int id, string nombre, string fechaNacimiento,  int empleadosACargo):base(id, nombre, fechaNacimiento)
        {
            this.EmpleadosACargo = empleadosACargo;
        }

        //Metodos
        public override string Mostrar()
        {
            return $"| ID:     {ID} / Nombre:   {Nombre} / Fecha de Nacimiento:   {FechaNacimiento} / Nro Empleados: {EmpleadosACargo}\n";   
        }

    }
}

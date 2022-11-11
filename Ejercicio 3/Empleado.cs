using System;
using System.Linq;


namespace Ejercicio_3
{
    internal class Empleado
    {

        //propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }

        JavierList list = new JavierList(5);

        //constructor por defecto

        public Empleado()
        {

        }

        // constructores 

        public Empleado(int id, string nombre, string fechaNacimiento)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;

        }

        //Metodos
        public virtual string Mostrar()
        {
            return $"| ID:     {ID} / Nombre:   {Nombre} / Fecha de Nacimiento:   {FechaNacimiento}\n";
        }

    }
}

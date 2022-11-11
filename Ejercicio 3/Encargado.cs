using System;
using System.Linq;


namespace Ejercicio_3
{
    internal class Encargado:Empleado
    {
        //propiedades
        public int SucursalesACargo { get; set; }

        //constructor por defecto
        public Encargado()
        {
        }

        // constructores 
        public Encargado(int id, string nombre, string fechaNacimiento, int sucursalesACargo):base(id, nombre, fechaNacimiento)
        {
            this.SucursalesACargo = sucursalesACargo;
        }

        //Metodos
        public override string Mostrar()
        {
            return $"| ID:     {ID} / Nombre:   {Nombre} / Fecha de Nacimiento:   {FechaNacimiento} / Nro Sucursales: {SucursalesACargo}\n";
                   
        }

    }
}

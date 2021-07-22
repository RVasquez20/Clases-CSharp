using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_objetos
{
    class Animal
    {
        public string clasificacion, nombre, categoria;
        public int edad = 0;
        public Animal()
        {

        }

        public Animal(string clasificacion, string nombre, string categoria, int edad)
        {
            this.clasificacion = clasificacion;
            this.nombre = nombre;
            this.categoria = categoria;
            this.edad = edad;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Clasificacion: " + clasificacion);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Categoría: " + categoria);
            Console.WriteLine("Edad: " + edad);

        }
    }
}

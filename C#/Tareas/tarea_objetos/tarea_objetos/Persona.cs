using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_objetos
{
    class Persona
    {
        public string nombre, apellido;
        public int edad;
        public double estatura;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad, double estatura)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.estatura = estatura;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Estatura: " + estatura);
        }
    }
}

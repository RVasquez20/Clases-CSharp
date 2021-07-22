 using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_objetos
{
    class Computadora
    {
        public string marca;
        public int ram;
        public double pulgadas;

        public Computadora()
        {

        }

        public Computadora(string marca, int ram, double pulgadas)
        {
            this.marca = marca;
            this.ram = ram;
            this.pulgadas = pulgadas;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("RAM: " + ram);
            Console.WriteLine("Pulgadas: " + pulgadas);
           
        }

    }
}

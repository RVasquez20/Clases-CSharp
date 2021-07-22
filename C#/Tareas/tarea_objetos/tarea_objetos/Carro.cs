using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_objetos
{
    class Carro
    {
        public string marca;
        public int anio = 0;
        public Carro()
        {
            
        }

        public Carro(string marca, int anio)
        {
            this.marca = marca;
            this.anio = anio;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Año: " + anio);
        }
    }
}

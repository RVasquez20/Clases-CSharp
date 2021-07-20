using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_III
{
    class Animal
    {
        public bool estructura;
        public string clasificacion;
        public int edad;

        public Animal(bool estructura,string clasificacion,int edad)
        {
            this.clasificacion = clasificacion;
            this.estructura = estructura;
            this.edad = edad;
        }

        public string mostrarDatos()
        {
            if (estructura)
            {
                return "Estructura:Vertebrado\nClasificacion:" + clasificacion + "\nEdad:" + edad +
                    "\n------------------------------";
            }
            else
            {
                return "Estructura:Invertebrado\nClasificacion:" + clasificacion + "\nEdad:" + edad +
                    "\n------------------------------";
            }
        }
    }
}

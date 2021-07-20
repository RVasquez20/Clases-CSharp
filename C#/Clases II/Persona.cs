using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_II
{
    class Persona
    {
        public string Nombre, Apellido;
        public int Edad;
        public double Estatura;

        //Constructor
        /*Permite iniciar o instanciar un objeto ya sea con datos o sin datos del mismo*/
      //  public Persona() { }

        //Dar valores a travez de el constructor
        /*Identifican que metodo utilizar si se llaman igual, por la cantidad
         de parametros que lleva cada uno*/
        public Persona(string Nombre,string Apellido, int Edad, double Estatura)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Edad = Edad;
            this.Estatura = Estatura;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre:"+Nombre);
            Console.WriteLine("Apellido:" + Apellido);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Estatura:" + Estatura);
            Console.WriteLine("-------------------------------------");
        }
    }
}

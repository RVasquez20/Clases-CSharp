using System;

namespace Clases_II
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Mensaje();
             Console.WriteLine(suma(2, 2));
             */
            //Crear o instanciar un objeto de la clase persona
            Persona obj1 = new Persona("Juan","Perez",35,1.79);
            obj1.MostrarDatos();
            Console.ReadKey();
        }

       /* public static int suma(int v1, int v2)
        {
            return v1 + v2;
        }

        public static void Mensaje()
        {
            Console.WriteLine("Hola mundo");
        }*/
    }
}

using System;

namespace Clases_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sobrecarga de Constructores*/

            Plantas p1 = new Plantas();
            p1.color = "Naranja";
            p1.MostrarDatos();
            Plantas p2 = new Plantas("Verde","1",false);
            p2.MostrarDatos();
            Console.WriteLine("Setter: Amarillo");
            p2.color="Amarillo";
            Console.WriteLine("Getter:"+p2.color);
            Plantas p3 = new Plantas("Azul","2",true);
            p3.MostrarDatos(7);
            Console.ReadKey();
        }
    }
}

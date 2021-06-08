using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programacion_Secuencial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza la carga de un lado de un cuadrado , muestra por pantalla el permiremtro del mismo
            //calculado
            /*double lado = 0.0, Perimetro = 0.0;
            Console.WriteLine("Ingrese un lado del Cuadrado:");
            lado = double.Parse(Console.ReadLine());
            Perimetro = lado * 4;
            Console.WriteLine("El Perimetro es " + Perimetro);
            Console.ReadKey();*/

            //Pedir y mostrar datos de una persona, Nombre,Fecha De Nacimiento.Mostrar La Edad

            string Nombre;
            int DiaNacimiento = 0, MesNacimiento = 0, AnioNacimiento = 0,Edad=0;


            Console.WriteLine("Ingrese el nombre");
            Nombre = Console.ReadLine(); 

            Console.WriteLine("Ingrese el dia de nacimiento");
            DiaNacimiento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el mes de nacimiento");
            MesNacimiento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el anio de nacimiento");
            AnioNacimiento = int.Parse(Console.ReadLine());

            

            Edad =  2021-AnioNacimiento;
            Console.WriteLine("Datos \n" +
                "Nombre:"+Nombre+
                "\nEdad:"+Edad+
                "\nFecha De Nacimiento: {0}/{1}/{2}",DiaNacimiento,MesNacimiento,AnioNacimiento);
            Console.ReadKey();

            //Tarea: 25 Programas a tu creatividad sobre Programacion Secuencial

            //Estructuras de flujo de control(Condicionales):if,ifelse,if anidados,switch
        }
    }
}

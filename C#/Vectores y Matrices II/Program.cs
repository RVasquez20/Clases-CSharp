using System;

namespace Vectores_y_Matrices_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector=Es una estructura de datos que contiene una coleccion de valores del mismo tipo
            //Para que ?= para almacenar valores que normalmente tienen alguna relacion entre si
            /*Ejemplo 1: Realice un programa en donde el usuario ingrese las notas(4) de un alumno
             , si el alumno obtubo un promedio mayor a 61 mostrar un mensaje en pantalla diciendo que aprobo
            de lo contrario mostrar un mensaje de error diciendo que reprobo*/

            /*double[] Notas = new double[4];
            double promedio = 0.0;
            Console.WriteLine("Ingrese las notas del alumno:");
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine("Ingrese la nota "+(i+1));
                Notas[i] = Double.Parse(Console.ReadLine());
            }
            foreach (double iterador in Notas)
            {
                promedio += iterador;
            }
            promedio /= 4;

            if (promedio>61)
            {
                Console.WriteLine("El alumno Aprobo");
            }
            else{
                Console.WriteLine("\a El Alumno Reprobo");
            }*/

            /*Ejemplo 2:Determinar la hipotenusa de un triángulo rectángulo conocidas las longitudes de sus dos
catetos.
            double ad = 0.0, op = 0.0,hi=0.0;
            Console.WriteLine("Ingrese la longitud de el cateto adyacente");
            ad = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud de el cateto opuesto");
            op =Convert.ToDouble(Console.ReadLine());
            hi = Math.Sqrt(Math.Pow(ad,2)+ Math.Pow(op, 2));
            Console.WriteLine("La hipotenusa es:"+hi);
            Console.ReadKey();
            */

            /*Ejemplo 3: Ingrese los datos para 2 vectores y calcule la suma de ambos en otro vector*/
            /*int Cantidad = 0;
            Console.WriteLine("Ingrese la cantidad de numeros a ingresar para un vector");
            Cantidad = int.Parse(Console.ReadLine());
            int[] N1 = new int[Cantidad];
            int[] N2 = new int[Cantidad];
            int[] Suma = new int[Cantidad];
            for (int i = 0; i <N1.Length ; i++)
            {
                Console.WriteLine("Ingrese el numero que ira en la posicion " + i + " del Vector 1");
                N1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N2.Length; i++)
            {
                Console.WriteLine("Ingrese el numero que ira en la posicion " + i + " del Vector 2");
                N2[i] = int.Parse(Console.ReadLine()); 

            }*/
            /*
              1         2       3
            * 0         1       2
            
              4         5       6
           *  0         1       2    +
           ----------------------------------
              5         7       9
            * 0         1       2
             */
            /*for (int i = 0; i < N1.Length; i++)
            {
                Suma[i] = N1[i] + N2[i];
            }
            foreach (int item in Suma)
            {
                Console.Write(item+",");
            }*/
            /*
             Ejemplo 4: Realice un programa en donde se muestren los valores del codigo ascii
             */
            char x;
            Console.WriteLine("Codigo\t\tValor");
            Console.WriteLine("-------------------");
            for (int i = 0; i < 256; i++)
            {               
                x = Convert.ToChar(i);
                Console.WriteLine(i+"\t\t"+x);
            }
            Console.ReadKey();
        }
    }
}

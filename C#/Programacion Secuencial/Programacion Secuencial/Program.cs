using System;

namespace Programacion_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //CamelCase
            int NumeroUno = 0,NumeroDos=0,Suma=0,Producto=0;
            string linea;

            Console.WriteLine("Ingrese el primer valor:");
            linea = Console.ReadLine();
            NumeroUno = Convert.ToInt32(linea);
            //NumeroUno = int.Parse(linea);
                   

            Console.WriteLine("Ingrese el Segundo valor:");
            NumeroDos = int.Parse(Console.ReadLine());

            linea = NumeroUno.ToString();

            /*  Operador            Operacion           Ejemplo             C#
             *  ------------------------------------------------------------------------
             *      +                 suma                2+3               x+y
             *      -                 resta               5-y               x-y
             *      *              multiplicacion         5*x               x*y
             *      /                   Division          5/2               x/y
             *     Mod              Modulo/Residuo        5mod2             x%y  
             * */

            Suma = NumeroUno + NumeroDos;
            Producto = NumeroUno * NumeroDos;

            Console.WriteLine("La Suma es :"+Suma);
            Console.WriteLine("El Producto de {0} * {1}  es:{2}",NumeroUno,NumeroDos,Producto);
            Console.ReadKey();

        }
    }
}

using System;

namespace Ciclos_I
{
    class Program
    {
       //Ciclos
       //for i,foreach,while,do while,Todos los ciclos pueden ser anidados
        static void Main(string[] args)
        {
            //Ejemplo 1: Contar de 0-9(10 numeros)
            //for (int i=0;i<10;i++)
            //{
            //0.1.2.3.4.5.6.7.8.9
            // Console.WriteLine("->"+(i+1));
            // }
            //Ejemplo 2: Contar de 9 hasta 0
            //for (int i = 9; i >= 0; i--)
            //{
            //0.1.2.3.4.5.6.7.8.9
            //  Console.WriteLine("->" + (i));
            //}
            //
            //Ejemplo 3:Realizar un programa que muestre los numeros multiplos de 9 entre el 1 y el 100
            //(Esto se puede realizar si no se trabajan Vectores o Matrices)
            //for(int i = 1; i <= 100; i++)
            //{
            //if (i % 9 == 0)
            //{
            //   Console.WriteLine(i);
            //}
            //  }

            //Ejemplo 4:Realice un programa en el cual se muestren 5 Veces cada letra de un nombre ingresado
            //string nombre;
            //J U A N, L=4
            //0 1 2 3
            //Console.WriteLine("Ingrese un nombre");
            //nombre = Console.ReadLine();
            //Length es la longiud del String
            //for (int i = 0; i < nombre.Length; i++)
            //{
            // for (int j = 0; j < 5;j++)
            //{
            //    Console.WriteLine(nombre[i]); 
            // }

            // }
            //Ejemplo 5 : Realice un programa en donde se muestren los numeros desde el 0 hasta
            //El numero indicado por el usuario y al finalizar se muestre la suma de todos ellos
            /*
             * OPERADOR             SIGNIFICADO         EJEMPLO
             * --------------------------------------------------
             *   ++                     +1                 i++
             *   --                     -1                 i--
             *   +=                   N=N+x                n+=x  (igual para los demas operadores)
             * 
             * */
            //Si no se inicializa la suma en 0, su valor es de 4 bytes si es int32 (4294967296), si es int64 su valor es de 4 bytes
            int suma = 0,fin=0;
            Console.WriteLine("Ingrese hasta que numero desea sumar");
            fin = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= fin; i++)
            {
                Console.WriteLine(i);
                suma += i;
                /*
                i             suma
                -------------------
                0            0=0+0->0   
                1            0=0+1->1
                2            1=1+2->3
                3            3=3+3->6
                4            6=6+4->10
                 */
            }
            Console.WriteLine("           +");
            Console.WriteLine("------------");
            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}

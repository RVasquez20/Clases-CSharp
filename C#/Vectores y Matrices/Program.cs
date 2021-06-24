using System;

namespace Vectores_y_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Maneras de declarar un vector*/
            //Definiendo los valores de los elementos que contendra
            int[] Vector1 = { 11,14,16,18,20};
            /*
             12     14      16      18      20
              0      1      2       3       4
             */
            //Declarar los espacios que contendra el vector (si son enteros todos inician en 0)
            string[] Vector2 = new string[4];

            /*Definiendo el vector para despues inicializarlo*/
            int[] Vector3;
            Vector3 =new int[4];

            ///////////////////////////////////////////////////////////////////////
            ///
            /*Ejemplo 1:utilizando el vector1 mostrar los elementos que se encuentren en las posiciones
             1,3,4*/
            /*Console.WriteLine(Vector1[1]);
            Console.WriteLine(Vector1[3]);
            Console.WriteLine(Vector1[4]);*/
            /*Ejemplo 2: Utilizando el vector 1 mostrar todos sus elementos*/
            /*for (int i = 0; i < Vector1.Length; i++)
            {
                Console.WriteLine(Vector1[i]);
            }*/
            /*Ejemplo 3: mostrar todos los elementos pares de un vector con foreach*/
            /*foreach (int i in Vector1)
            {
                if (i%2==0) { Console.WriteLine(i); }
                
            }*/
            //////////////////////////////////////////////////////////////////////////////
            /*Ejemplo 4: realice un programa en donde ingrese 4 numeros enteros y me muestre los que
             sean pares*/
            /* int[] Array = new int[4];
             for (int i = 0; i < Array.Length; i++)
             {
                 Console.WriteLine("Ingrese el numero que ira en la posicion "+(i+1));
                 Array[i] = int.Parse(Console.ReadLine());
             }
             foreach (int i in Array)
             {
                 if (i % 2 == 0) { Console.WriteLine(i); }

             }*/
            /*Ejemplo 5 : realice un programa en donde ingrese la cantidad de nombres que diga el usuario 
             y posteriormente mostrarlos*/
            /*  int Cantidad = 0;
              Console.WriteLine("Cuantos nombres desea ingresar?");
              Cantidad = int.Parse(Console.ReadLine());
              string[] Nombres = new string[Cantidad];
              for (int i = 0; i < Nombres.Length; i++)
              {
                  Console.WriteLine("Ingrese el nombre que ira en la posicion " + i);
                  Nombres[i] = Console.ReadLine();
              }

              for (int i = 0; i < Nombres.Length; i++)
              {
                  Console.WriteLine("Nombres["+i+"]="+Nombres[i]);
              }
            */
            /*Ejemplo 6: Muestre la cantidad de elementos que contiene el Vector 1*/
            //Console.WriteLine(Vector1.Length);
            /*Ejemplo 7: Coloque el numero 100 en la posicion 1 del Vector 1*/
            /*Vector1[1] = 100;
            foreach (int i in Vector1)
            {
                Console.WriteLine(i); 

            }*/
            Console.ReadKey();
        }
    }
}

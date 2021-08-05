using System;

namespace Vectores_y_Matrices_V
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar una matriz
            // int[,] m1 = new int[2,2]; declarando espacios vacios
            /*
          i\j 0 1 2

          0   1 2 3
          1   4 5 6 
          2   7 8 9
             */
            //int[,] m2 = { { 1,2,3},{ 4, 5, 6 },{ 7, 8, 9 } };
            //Mostrar la matriz

            /* for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.Write(m2[i,j]);
                 }
                 Console.WriteLine("");
             }*/

            /*
             Hacer una matriz en donde le pida al usuario el numero de filas y columnas , posteriormente mostrar la matriz
            en pantalla ya llena
             */
            int filas = 0, columnas = 0;
            Console.WriteLine("Ingrese la cantidad de filas");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            columnas = int.Parse(Console.ReadLine());
            int [,]matriz = new int[filas, columnas];
            Console.Clear();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el numero que ira en la posicion [{0},{1}]",i,j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Numero en la posicion [{0},{1}]={2}", i, j, matriz[i, j]);
                    
                }
            }
            Console.ReadKey();
        }
    }
}

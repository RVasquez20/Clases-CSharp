using System;

namespace Clases_III
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Animal obj1 = new Animal(true,"Aves",1);
             Console.WriteLine(obj1.mostrarDatos());
            */
            Calculadora c1;
            char opcRepite;
            do {
                int cantidad = 0, opc = 0;
                Console.WriteLine("Ingrese la cantidad de numeros que va a operar");
                cantidad = int.Parse(Console.ReadLine());
                Console.Clear();
                double[] numeros = new double[cantidad];
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine($"Ingrese el {(i+1)} º numero");
                    numeros[i] = double.Parse(Console.ReadLine());
                }
                Console.Clear();
                c1 = new Calculadora(numeros);
                Console.WriteLine("Menu de operaciones");
                Console.WriteLine("---------------------");
                Console.WriteLine("1)Sumar");
                Console.WriteLine("2)Restar");
                Console.WriteLine("3)Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            Console.WriteLine("La suma es:"+c1.suma());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("La resta es:" + c1.resta());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Gracias por utilizar el programa");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion no disponible");
                            break;
                        }
                }
                Console.WriteLine("Desea realizar otra operacion S|N?");
                opcRepite = char.Parse(Console.ReadLine());
            } while (opcRepite=='S');
            Console.ReadKey();
        }
       
    }
}

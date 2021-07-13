
using System;

namespace Tarea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, compr = 0, numev = 1, num = 0, notas=0;
            double cat1 = 0, cat2 = 0, hipotenusa = 0;
            Console.WriteLine("Seleccione la opción que desea realizar: ");
            Console.WriteLine("1) Hipotenusa");
            Console.WriteLine("2) Comprobación del número");
            Console.WriteLine("3) Calificaciones numéricas");
            Console.WriteLine("4) Orden de menor a mayor");
            Console.WriteLine("5) Velocidad de un automóvil");
            Console.WriteLine("6) Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese un cateto");
                        cat1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el otro cateto");
                        cat2 = Double.Parse(Console.ReadLine());
                        hipotenusa = Math.Sqrt(Math.Pow(cat1,2) + Math.Pow(cat2,2));
                        Console.WriteLine("La hipotenusa es: " + hipotenusa);
                        break;
                    }
                case 2:
                    {
                        int fact = 0;
                        Console.WriteLine("Seleccione la opción que desea comprobar: ");
                        Console.WriteLine(" 1) Primo");
                        Console.WriteLine(" 2) Factorial");
                        Console.WriteLine(" 3) Tabla de multiplicar");
                        compr = int.Parse(Console.ReadLine());
                        
                       

                        Console.WriteLine("Ingrese el número a evaluar");
                        numev = int.Parse(Console.ReadLine());
                        switch (compr)
                        {

                            case 1:

                                {
                                    if (numev%2==1)
                                    {
                                        Console.WriteLine("El número ingresado es primo");

                                    }
                                    else
                                    {
                                        Console.WriteLine("El número ingresado no es primo");

                                    }
                                    break;
                                }
                            case 2:
                                {
                                    for (int i = 1; i <= numev; i++)
                                    {
                                        fact *= i;
                                    }
                                    Console.WriteLine("El factorial del número es: " +fact);
                                    break;
                                }
                            case 3:
                                {
                                    int multi = 1;
                                    int[] tabla = new int[numev];
                                    for (int i = 1; i <= tabla.Length; i++)
                                    {
                                        multi = numev*i;
                                      
                                    }
                                    for (int i = 1; i <= tabla.Length; i++)
                                    {
                                        Console.WriteLine("La tabla de multiplicar será " + tabla[i]);

                                    }
                                    
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Ingrese una opción válida");
                                    break;
                                }
                                
                        }
                        break;
                    }

                case 3:
                    {
                        
                        Console.WriteLine("Ingrese la calificación");
                      
                        num = int.Parse(Console.ReadLine());
                        if ((num >1)&&(num <20))
                        {
                            if ((num == 19) && (num == 20))
                            {
                                Console.WriteLine("A");
                            }
                            else if ((num == 16) && (num == 17) && (num == 18))
                            {
                                Console.WriteLine("B");
                            }
                            else if ((num == 13) && (num == 14) && (num == 15))
                            {
                                Console.WriteLine("C");
                            }
                            else if ((num == 10) && (num == 11) && (num == 12))
                            {
                                Console.WriteLine("D");
                            }
                            else if ((num == 9) && (num == 8) && (num == 7) && (num == 6) && (num == 5) && (num == 4) && (num == 3) && (num == 2) && (num == 1))
                            {
                                Console.WriteLine("E");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese una nota comprendida entre 1 y 20");
                            }
                        } 
                        break;
                    }
                case 4:
                    {
                        for (int i = notas.Length - 1; i >= 0; i--)
                        {
                            Console.Write(notas[i] + ",");
                        }
                        Array.Reverse(V1);
                        break;
                    }
                     
                    
                case 5:
                    {
                        int km = 0, hora = 0, metros = 0, segundos = 0;
                        Console.WriteLine("Ingrese la distancia recorrida en km");
                        km = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la valocidad recorrida en segundos");
                        hora = int.Parse(Console.ReadLine());

                        metros = km / 1000;
                        segundos = hora / 60;
                        Console.WriteLine("los metros recorridos son: " + metros + " en: " + segundos);

                        break;
                    }
                case 6:
                    {
                        Environment.Exit(0);
                        break;
                    }
                 default:
                    {
                        Console.WriteLine("Ingrese una opción válida");
                        break;
                    }
                    
            }
            Console.ReadKey();

        }
    }
}

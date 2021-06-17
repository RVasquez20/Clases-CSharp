using System;

namespace Ciclos_II
{
    class Program
    {
        //Ciclo while
        static void Main(string[] args)
        {
            //Solucion de duda: mostrar los numeros impares del 1 al 100 e imprimir cuantos son.
            /*   int contador = 0;
           for(int i = 0; i < 100; i++)
               {
                   if (i % 2 != 0)
                   {
                       contador++;
                       Console.WriteLine(i);
                   }
               }
               Console.WriteLine("El total de impares es:"+contador);*/


            //todas las variables de tipo bool tienen que ser inicializadas
            //bool continuar = true;
            //si se coloca una variable de tipo bool en cualquier condicion sin el simbolo '!' la condicion sera
            //que la variable sea verdadera

            /*Ejemplo 1:Pedir al usuario 2 numeros y mostrar la suma, preguntar si desea seguir , si responde si, continua 
             en caso contrario se detiene
            while (continuar)
            {
                continuar = false;
                Console.WriteLine("Ingrese un numero");
                int numeroUno = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero");
                int numeroDos = int.Parse(Console.ReadLine());
                Console.WriteLine("La suma es: "+(numeroUno+numeroDos));
                Console.WriteLine("Desea Continuar? Si/No");
                string opc = Console.ReadLine();
                if (opc.Equals("Si"))
                {
                    continuar = true;
                }
               
            }
            */
            //Ejemplo 2: mostrar los numeros impares del 0 al 100 y mostrar la cantidad de numeros impares que existen
            /*int i= 0,contador=0;
            while (i<100)
            {
                if (i % 2 != 0)
                {
                    contador++;
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine("El total de impares es:" + contador);
            */
            /*Ejemplo 3: Realizar un menu en donde se muestren las 4 operaciones basicas y al finalizar preguntar al usuario si desea
             continuar y realizar otra operacion*/
            
            bool continuar = true;
            while (continuar) {
                Console.Clear();
                continuar = false;
                double numeroUno = 0, numeroDos = 0;
                int opcionMenuPrincipal = 0;
                string opc;
                Console.WriteLine("---------Menu Principal---------");
                Console.WriteLine("         1)Sumar");
                Console.WriteLine("         2)Restar");
                Console.WriteLine("         3)Multiplicar");
                Console.WriteLine("         4)Dividir");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Seleccione la opcion que desea:");
                opcionMenuPrincipal = int.Parse(Console.ReadLine());
                switch (opcionMenuPrincipal)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese un numero");
                            numeroUno = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un numero");
                            numeroDos = int.Parse(Console.ReadLine());
                            Console.WriteLine("La suma es:"+(numeroUno+numeroDos));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ingrese un numero");
                            numeroUno = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un numero");
                            numeroDos = int.Parse(Console.ReadLine());
                            Console.WriteLine("La resta es:" + (numeroUno - numeroDos));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ingrese un numero");
                            numeroUno = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un numero");
                            numeroDos = int.Parse(Console.ReadLine());
                            Console.WriteLine("La multiplicacion es:" + (numeroUno * numeroDos));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ingrese un numero");
                            numeroUno = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un numero");
                            numeroDos = int.Parse(Console.ReadLine());
                            Console.WriteLine("La division es:" + (numeroUno / numeroDos));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion incorrecta");
                            Console.ReadKey();
                            break;
                        }

                }
                Console.WriteLine("Desea Continuar? Si/No");
                opc = Console.ReadLine();
                if (opc.Equals("Si")|| opc.Equals("si")|| opc.Equals("SI"))
                {
                    continuar = true;
                }
            }
            Console.ReadKey();
        }
    }
}

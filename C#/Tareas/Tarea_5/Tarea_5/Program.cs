using System;

namespace Tarea_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, dias = 0, anios = 0, meses = 0, semanas = 0;
            int diasrestantes=0;
            int[] nota = new int[10];
            int[] numero1 = new int[10];
            int[] numero2 = new int[10];
            int[] suma = new int[10];
            int[] resta = new int[10];
            int[] multiplicacion = new int[10];
            int[] division = new int[10];
            int[] resultante = new int[10];
            string usuario;
          
            do
            {
                Console.Clear();
                Console.WriteLine(" Seleccione la opción que desea realizar");
                Console.WriteLine(" 1)  Nota mayor");
                Console.WriteLine(" 2)  Operaciones básicas");
                Console.WriteLine(" 3)  Resta sin el operador -");
                Console.WriteLine(" 4)  Determinar años, meses, días");
                Console.WriteLine(" 5)  Promedio sueldo anual");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {

                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("Ingrese la nota");
                                nota[i] = int.Parse(Console.ReadLine());
                                Array.Sort(nota);
                                
                            }
                            Console.Write("La nota mayor es:  "+nota[9]);

                            break;
                        }
                    case 2:
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                Console.WriteLine("Ingrese un número");
                                numero1[j] = int.Parse(Console.ReadLine());
                            }
                            for (int j = 0; j < 10; j++)
                            {
                                Console.WriteLine("Ingrese un número");
                                numero2[j] = int.Parse(Console.ReadLine());
                            }
                            for (int op = 0; op < 10; op++)
                            {
                                suma[op] = numero1[op] + numero2[op];
                                resta[op] = numero1[op] - numero2[op];
                                multiplicacion[op] = numero1[op] * numero2[op];
                                division[op] = numero1[op] / numero2[op];
                                resultante[op] = suma[op] * resta[op] * multiplicacion[op] * division[op];
                                Console.WriteLine("el resultado de la multiplicación será: " + resultante[op]);
                            }
                            
                            
                            break;
                        }
                    case 3:
                        {
                            /*a=6;
                              b=2+1=3+1=4+1=5+1=6;
                              res=0/1/2/3/4;
                            */
                            int a = 0, b = 0, res=0;
                            Console.WriteLine("Ingrese un número");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el número a restar");
                            b = int.Parse(Console.ReadLine());
                            for (res = 0; b < a; res++) b++;

                            Console.WriteLine(res);

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ingrese el número de días");
                            dias = int.Parse(Console.ReadLine());
                           
                                anios = dias / 365;
                               
                               
                                meses = dias / 30;
                                
                                semanas = dias / 7;
                                

                            
                            Console.WriteLine("Los años son: " + anios);
                            Console.WriteLine("Los años son: " + meses);
                            Console.WriteLine("Los años son: " + semanas);
                            Console.WriteLine("Los años son: " + dias);
                            break;
                        }
                    case 5:
                        {
                            
                            int cantidad = 0;
                            Console.WriteLine("Ingrese la cantidad de sueldos que desea evaluar");
                            cantidad = int.Parse(Console.ReadLine());
                            int[] promedio = new int[cantidad];


                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Seleccione una opción válida");
                            break;
                        }

                }
                Console.WriteLine("¿Desea continuar?");
                usuario = Console.ReadLine();
            }
            while (usuario.Equals("Si"));
            {

            }

            Console.ReadKey();
        }
    }
}

using System;

namespace Tarea2_ER
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejericio 1: Sueldo semanal

            int HorasTrabajadas = 0, PagoSemanal = 0, HorasExtra=0;

            Console.WriteLine("Ingrese las horas trabajadas");
            HorasTrabajadas = int.Parse(Console.ReadLine());

            if (HorasTrabajadas<=40)
            {
                PagoSemanal = HorasTrabajadas * 20;
                Console.WriteLine("El sueldo semanal será de: " + PagoSemanal);
            }
            else
            {
                Console.WriteLine("Ingrese las horas trabajadas");
                HorasTrabajadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese las horas extras trabajadas");
                HorasExtra = Convert.ToInt32(Console.ReadLine());

                PagoSemanal = (HorasTrabajadas * 20) + (HorasExtra * 25);
                Console.WriteLine("El sueldo semanal será de: " + PagoSemanal);
            }
            Console.WriteLine("---------------------------------------------------------------------------------");



            //Ejercicio 2: Multiplo de 7

            int num = 0;

            Console.WriteLine("Ingrese el número a evaluar");
            num = int.Parse(Console.ReadLine());

            if (num%7==0)
            {
                Console.WriteLine("Sí es múltiplo de 7");
            }
            else
            {
                Console.WriteLine("No es múltiplo de 7");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");

            //Ejercicio 3: Ganador del premio
            int numero = 0;

            Console.WriteLine("Ingrese un número para saber si es el ganador");
            numero = int.Parse(Console.ReadLine());

            if (numero == 1000)
            {
                Console.WriteLine("Ganaste un premio");
            }
            else
            {
                Console.WriteLine("Lo sentimos, no ganaste");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            //Ejercicio 4: Número menor
            int num1 = 0, num2 = 0;
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 <num2)
            {
                Console.WriteLine("El número menor es: " + num1);
            }
            else
            {
                Console.WriteLine("El número menor es: " + num2);
            }
            Console.WriteLine("-------------------------------------------------------------------------------");

            //Ejercicio 5: Día de la semana
            int NumIngresado = 0;
            Console.WriteLine("Ingrese el número del día de la semana");
            NumIngresado = int.Parse(Console.ReadLine());

            if (NumIngresado == 1)
            {
                Console.WriteLine("Lunes");
            }
            else
            {
                if (NumIngresado == 2)
                {
                    Console.WriteLine("Martes");
                }
                else
                {
                    if (NumIngresado == 3)
                    {
                        Console.WriteLine("Miércoles");
                    }
                    else
                    {
                        if (NumIngresado == 4)
                        {
                            Console.WriteLine("Jueves");
                        }
                        else
                        {
                            if (NumIngresado == 5)
                            {
                                Console.WriteLine("Viernes");
                            }
                            else
                            {
                                if (NumIngresado == 6)
                                {
                                    Console.WriteLine("Sábado");
                                }
                                else
                                {
                                    if (NumIngresado == 7)
                                    {
                                        Console.WriteLine("Domingo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese un número del 1 al 7");
                                    }
                                }
                            }
                        }
                    }
                }
            }



            Console.ReadKey();
        }
    }
}

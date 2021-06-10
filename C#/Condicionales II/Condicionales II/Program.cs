using System;

namespace Condicionales_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            string Dia;

            // Console.WriteLine("Ingrese un numero");
            //Numero =int.Parse(Console.ReadLine());
            //if (Numero==1)
            //{
            //Console.WriteLine("Hoy es Lunes");
            // }
            //else if (Numero == 2)
            // {
            // Console.WriteLine("Hoy es Martes");
            // }
            //else if (Numero == 3)
            // {
            // Console.WriteLine("Hoy es Miercoles");
            //}
            //else if (Numero == 4)
            //{
            //Console.WriteLine("Hoy es Jueves");
            //}
            // else if (Numero == 5)
            // {
            // Console.WriteLine("Hoy es Viernes");
            //}
            // else if (Numero == 6)
            //{
            // Console.WriteLine("Hoy es Sabado");
            //}
            // else if (Numero == 7)
            // {
            // Console.WriteLine("Hoy es Domingo");
            //}
            //else
            //  {
            // Console.WriteLine("Numero no valido");
            // }


            // Console.WriteLine("Ingrese un numero");
            // int NumeroDos = int.Parse(Console.ReadLine());

            //Estructura de un switch.
            //switch (NumeroDos)
            // {
            //  case 1:
            //{
            // Console.WriteLine("Hoy es lunes");
            // break;
            //}

            // case 2:
            //{
            //Console.WriteLine("Hoy es Martes");
            //break;
            //}
            //  case 3:
            //{
            //Console.WriteLine("Hoy es Miercoles");
            //break;
            //}
            // case 4:
            // {
            // Console.WriteLine("Hoy es Jueves");
            // break;
            // }
            // case 5:
            //{
            // Console.WriteLine("Hoy es Viernes");
            // break;
            // }
            //  case 6:
            //  {
            // Console.WriteLine("Hoy es Sabado");
            //        break;
            //}
            // case 7:
            //    {
            //      Console.WriteLine("Hoy es Domingo");
            //        break;
            //    }
            //  default: {
            //         Console.WriteLine("Numero no valido");
            //         break;
            //          }

            //}

            Console.WriteLine("Ingrese un dia de la semana");
            Dia = Console.ReadLine();
            switch (Dia)
            {
                case "Lunes":
                    {
                        Console.WriteLine("1");
                        break;
                    }
                case "Martes":
                    {
                        Console.WriteLine("2");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Dia no valido");
                        break;
                    }
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int numero, numero2, suma;

            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número");
            numero2 = int.Parse(Console.ReadLine());

            suma = numero + numero2;

            Console.WriteLine("El resultado de la suma es:" + suma);

          

            //2
            string figura;
            int lado, altura, area;

            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre de la figura");
            figura = Console.ReadLine();

            Console.WriteLine("Ingrese un lado del triángulo");
            lado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo");
            altura = int.Parse(Console.ReadLine());

            area = (lado * altura) / 2;

            Console.WriteLine("El área del " +figura +"\nes:"+ area);


            //3

            int num1, num2, ope;
           
            Console.WriteLine();
            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La operación a realizar será " + num1+" +" + num2 +" +"+num2+ " *" +num2);
            ope = num1 + num2 + num2 * num2;

            Console.WriteLine("El resultado de la operación es"+ ope);


            Console.ReadKey();
        }
    }
}

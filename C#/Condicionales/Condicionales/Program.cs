using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prueba;
            int numero = 0;
            string palabra;
            //if,if else,if anidados,switch
            //if

            //Ejemplo 1: Cuando el usuario ingrese un numero mayor a 0
            //Console.WriteLine("Ingrese un numero");
            //numero = int.Parse(Console.ReadLine());
            //if (numero > 0) 
            //{
            //    Console.WriteLine("Es Positivo");
            //}
            //if (numero < 0)
            //{
            //   Console.WriteLine("Es Negativo");
            //}

            //Ejemplo 2 : Ingrese un color y diga como es en ingles
            //Console.WriteLine("Ingrese un color");
            //palabra = Console.ReadLine();
            //if (palabra == "Azul")
            //{
            //   Console.WriteLine("Blue");

            // }
            // if (palabra.Equals("Rojo"))
            // {
            //    Console.WriteLine("Red");
            //}
            // if (palabra.Equals("Verde"))
            //{
            //  Console.WriteLine("Green");
            //  }
            //!=
            //!(Not) ==(equals) -> != (Negando que sean iguales)
            // if (!palabra.Equals("Violeta"))
            // {
            //     Console.WriteLine("Desconocido");
            // }


            //if else
            //Ejemplo 3: Realice un programa en donde muestre si el numero ingresado es positivo o negativo
            //Console.WriteLine("Ingrese un numero");
            //numero = Convert.ToInt32(Console.ReadLine());
            //if (numero>0)
            //{
            //    Console.WriteLine("Es Positivo");
            //}
            // else
            //{
            //   Console.WriteLine("Es Negativo");
            // }

            //Ejemplo 4:Validar si prueba es verdadero cambiarla a falsa y si es falsa cambiarla a verdadero
            //si(prueba es verdadero) o si(!prueba)=si prueba es falso
            //prueba = true;
            //si se coloca una variable de tipo bool en un if(sin ! antes de la varibale) eso indica que la primera condicion a
            //evaluarse sera si la variable es verdadera
            // if (prueba)
            //{
            //   prueba = false;

            //   Console.WriteLine(prueba);
            // }
            // else
            // {
            //    prueba = true;

            //    Console.WriteLine(prueba);
            //}

            //Ejemplo 5: pedir un numero al usuario y preguntarle sobre que multiplo desea ver si es y mostrar si es multiplo o no

            // int numeroDos = 0;
            //Console.WriteLine("Ingrese el numero a evaluar");
            //numero = int.Parse(Console.ReadLine());

            // Console.WriteLine("Ingrese el numero sobre el cual sera multiplo");
            // numeroDos = int.Parse(Console.ReadLine());
            //Un numero es multiplo de otro si y solo si el residuo de la division es 0
            //if (numero%numeroDos==0)
            //{
            //    Console.WriteLine(numero + " es multiplo de " + numeroDos);
            //}
            // else
            // {
            //    Console.WriteLine(numero + " No es multiplo de " + numeroDos);
            //}

            //if anidados
            //Ejemplo 6: realice un programa para seleccionar a un empleado para la empresa C# S.A
            //El empleado debe ser mayor de edad y su nombre no debe ser "Maria"
            int Edad = 0;
            string Nombre;
            Console.WriteLine("Ingrese el nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            Edad =int.Parse( Console.ReadLine());

            if (Edad>18)
            {
                if (Nombre.Equals("Maria"))
                {
                    Console.WriteLine("No admitida");
                }
                else
                {
                    Console.WriteLine("Admitid@");
                }
            }
            else
            {
                Console.WriteLine("No admitid@ por ser menor de edad");
            }

            Console.ReadKey();
        }
    }
}

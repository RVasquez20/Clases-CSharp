using System;

namespace tarea_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

            
            Console.ReadKey();
        }

        public static void Persona()
        {
            string Nombre, Apellido;
            int edad;
            double estatura;

            Console.WriteLine("Ingrese el nombre de la persona");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de la persona");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la estatura de la persona");
            estatura = double.Parse(Console.ReadLine());

            Persona obj1 = new Persona(Nombre, Apellido, edad, estatura);
            obj1.MostrarDatos();
        }

        public static void Animal()
        {
            string clasificacion, nombre, categoria;
            int edad;


            Console.WriteLine("Ingrese la clasificación del animal (mamifero, ave, pez, reptil, amfibios");
            clasificacion = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del animal");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la categoría del animal (vertebrado, invertebrado");
            categoria = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del animal");
            edad = int.Parse(Console.ReadLine());

            Animal obj2 = new Animal(clasificacion, nombre, categoria, edad);
            obj2.MostrarDatos();
        }

        public static void Carro()
        {
            string marca;
            int anio = 0;

            Console.WriteLine("Ingrese la marca del auto");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese el año del auto");
            anio = int.Parse(Console.ReadLine());

            Carro obj3 = new Carro(marca, anio);
            obj3.MostrarDatos();
        }


        public static void Computadora()
        {
            string marca;
            int ram = 0;
            double pulgadas = 0;

            Console.WriteLine("Ingrese la marca de la computadora");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de RAM de la computadora");
            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las pulgadas de la pantalla de su computadora");
            pulgadas = double.Parse(Console.ReadLine());

            Computadora obj4 = new Computadora(marca, ram, pulgadas);
            obj4.MostrarDatos();
        }


        public static void menu()
        {

            int opcion = 0;
            Console.WriteLine("      Menú de objetos");
            Console.WriteLine("Seleccione el objeto que desea ingresar");
            Console.WriteLine("       1) Persona");
            Console.WriteLine("       2) Animal");
            Console.WriteLine("       3) Carro");
            Console.WriteLine("       4) Computadora");
            Console.WriteLine("       5) Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        Persona();
                        break;
                    }
                case 2:
                    {
                        Animal();
                        break;
                    }
                case 3:
                    {
                        Carro();

                        break;
                    }
                case 4:
                    {
                        Computadora();
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("La opción seleccionada no es válida");
                        break;
                    }
                    
            }
        }
    }
}

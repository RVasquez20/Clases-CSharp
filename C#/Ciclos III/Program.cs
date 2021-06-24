using System;

namespace Ciclos_III
{
    class Program
    {
        //do while
        static void Main(string[] args)
        {
            string opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1).Sumar");
                Console.WriteLine("1).Sumar");
                Console.WriteLine("1).Sumar");
                Console.WriteLine("1).Sumar");
                Console.WriteLine("1).Sumar");
                Console.WriteLine("Desea Continuar? SI/NO");
                opc = Console.ReadLine();
            } while (opc.Equals("SI"));
            //WF
            //Vectores y Matrices
            /*
             Operador       Simbolos        Significado
            ---------------------------------------------------------------------------------
               Not              !               Negacion;Por ejemplo !true=false(Cuando se niega algo es el caso contrario)
               And              &&          Y(Esto sera verdadero cuando si y solo si 2 o mas condiciones se cumplen)
               Or               ||          O(Esto sera verdadero cuando una de las 2 o mas condiciones se cumplan)
             
             */
        }
    }
}

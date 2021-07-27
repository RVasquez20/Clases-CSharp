using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_IV
{
    class Plantas
    {
        /*Modificadores de acceso(Getters and Setters):
         Getters=devuelven el valor de un atributo
         Setters=dan un valor a un atributo
        */
        private string  tipo;
        private bool frutos;
        private int cantidadDeFrutos;
        /*Ejemplo de getter antiguo
        public string getColor()
        {
            return color;
        }
        Ejemplo de setter antiguo
        public void setColor(string color)
        {
            this.color = color;
        }*/
        /*
         Si se declara el setter and getter ya no es necesario colocar
        el atributo
         */
        public string color { get; set; }
        public Plantas() {}

        public Plantas(string color,string tipo,bool frutos)
        {
            this.color = color;
            this.tipo = tipo;
            this.frutos = frutos;
            this.cantidadDeFrutos = 0;
        }

        public Plantas(string color, string tipo, bool frutos,int cantidadDeFrutos)
        {
            this.color = color;
            this.tipo = tipo;
            this.frutos = frutos;
            this.cantidadDeFrutos = cantidadDeFrutos;
        }
        /*
         Sobrecarga de metodos:
        pueden existir metodos del mismo tipo, del mismo nombre, pero su diferencia
        sera la cantidad de parametros
         */
        public void MostrarDatos()
        {
            Console.WriteLine($"Color:{color}");
            Console.WriteLine("Tipo:{0}",tipo);
            Console.WriteLine("Frutos:"+frutos);
            Console.WriteLine("Cantidad:"+cantidadDeFrutos);
        }
        public void MostrarDatos(int cantidad)
        {
            Console.WriteLine($"Color:{color}");
            Console.WriteLine("Tipo:{0}", tipo);
            Console.WriteLine("Frutos:" + frutos);
            Console.WriteLine("Cantidad:" + cantidad);
        }
    }
}

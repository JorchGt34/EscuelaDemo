using System;

namespace HelloWorld
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int fechaFundacion;
        public string ceo = "Freddy Vega";

        public void Timbrar() 
        {
            //ToDo: Implementar el timbre
            //Console.Beep(10000, 3000); Solo funciona en Windows
            Console.WriteLine("Timbrando....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Cr 9 calle 72";
            miEscuela.fechaFundacion = 2012;
            miEscuela.ceo = "Otro Freddy Vega";
            //miEscuela.Timbrar(); Solo funciona en Windows
        }
    }
}
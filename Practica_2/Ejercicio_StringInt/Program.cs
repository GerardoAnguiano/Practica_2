using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;
            //1 pedir por consola el nombre de una persona 
            Console.WriteLine("Por favor escribe tu nombre");
            nombre = Console.ReadLine();
            //2 pedir la edad 
            Console.WriteLine("Escribe tu edad");
            edad = int.Parse (Console.ReadLine());
            //3 mostrar en pantalla 
            Console.WriteLine("Te llamas" + nombre + "y tienes" + edad);
            Console.WriteLine("Presiona cualquioer tecla para continuar");
            Console.ReadKey();
        }
    }
}

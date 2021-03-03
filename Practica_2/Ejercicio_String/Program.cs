using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String ciudad;
            //1 pedir por consola el nombre de una persona 
            Console.WriteLine("Por favor escribe tu nombre");
            nombre = Console.ReadLine();
            //2 pedir el nombre de una ciudad 
            Console.WriteLine("Escribe tu ciudad");
            ciudad = Console.ReadLine();
            //3 mostrar en pantalla 
            Console.WriteLine("Hola" + nombre + "Bienvenido a" + ciudad);
            Console.WriteLine("Presiona cualquioer tecla para continuar");
            Console.ReadKey();

        }
    }
}

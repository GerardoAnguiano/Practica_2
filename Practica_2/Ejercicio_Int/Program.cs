using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar tres variables de tipo int y asignarles valore estaticos
            int numero_1 = 5; 
            int numero_2 = 20;
            int numero_3 = 10;
            //2 crear una variable de tipo int la cual guardara la suma de las tres variables
            int suma = numero_1 + numero_2 + numero_3;

            //3 mostrar en pantalla el valor de suma "el valor de suma es"
            Console.WriteLine("El valor de suma es" + suma);
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}

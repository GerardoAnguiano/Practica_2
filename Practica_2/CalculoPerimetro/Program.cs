using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar tres variables de tipo int y asignarles valore estaticos
            int a = 10;
            int b = 10;
            int c = 25;
            //2 crear una variable de tipo int la cual guardara la suma de las tres variables
            int suma = a + b + c;

            //3 mostrar en pantalla el valor de suma "el perimetro del triangulo es "
            Console.WriteLine("El perimetro del triangulo es " + suma);
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}

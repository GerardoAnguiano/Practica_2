using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar tres variables de tipo int y asignarles valore estaticos
            int num1, num2, resultado;
            String linea;

            //soliciar numeros al ususario 
            Console.WriteLine("ingresa el primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingreso el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            resultado = num1 + num2;
            Console.WriteLine("la suma es {0} ", resultado);

            //resta
            resultado = num1 - num2;
            Console.WriteLine("la resta es:{0} ", resultado);

            //multiplicacion
            resultado = num1 * num2;
            Console.WriteLine("la multiplicacion es:{0} ", resultado);

            //division
            resultado = num1 / num2;
            Console.WriteLine("la division es:{0} ", resultado);

            //Residuo
            resultado = num1 % num2;
            Console.WriteLine("el residuo es:{0} ", resultado);

        }
    }
}

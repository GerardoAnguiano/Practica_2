using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar tres variables de tipo int y asignarles valore estaticos
            int cantidadburger, cantidadpapas, cantidadbebidas;
            double total;
            string linea;
            const double precioburger = 45;
            const double preciobebida = 15;
            const double preciopapas = 20;

            //solicitar orden
            Console.WriteLine("ingresar cantidad de hamburguesas");
            linea = Console.ReadLine();
            cantidadburger = int.Parse(linea);

            Console.WriteLine("ingresar cantidad de bebidas");
            linea = Console.ReadLine();
            cantidadbebidas = int.Parse(linea);

            Console.WriteLine("ingresar cantidad de papas");
            linea = Console.ReadLine();
            cantidadpapas = int.Parse(linea);

            //total
            total = (cantidadburger * precioburger) + (cantidadbebidas * preciobebida) + (cantidadpapas * preciopapas);

            Console.WriteLine("El total a pagar es de :" + total);
            Console.WriteLine("Presiona cualquioer tecla para continuar");
            Console.ReadKey();



        }
    }
}

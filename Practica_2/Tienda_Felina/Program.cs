using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Felina
{
    class Program
    {
        static void Main(string[] args)
        {
            int catidadlatas;
            double total;
            const double preciolata = 2;
            //Mostrar mensaje de bienvenida
            System.Console.WriteLine("Bienvenido a la tienda de comida para gatos");
            System.Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadLine();
            // pedir la cantidad de latas a ordenar  
            Console.WriteLine("Escribe la cantidad de latas que deseas ordenar ");
            catidadlatas = int.Parse(Console.ReadLine());
            //calcular el total de la ccompra 
            total = (preciolata * catidadlatas);
            //Calculo del total con descuento por compra a mayoreo 
            // if (Cantidadlatas < 50) 
            //total = cantidadlatas * 1.75;

           // el usuario pidio 50 latas y el total es + total
                        // }
             //else
             //if(cantidadlatas > 100)
             //{
             //total = cantidadlatas*1.50;
               //}
    Console.WriteLine("El total a pagar es de :" + total);
            Console.WriteLine("Presiona cualquioer tecla para continuar");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPago
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir precio del producto 
            Console.WriteLine("escriba precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            //pedir forma de pago con tarjeta o en efectivo 
            Console.WriteLine("escriba la forma de pago tarjeta o efectivo");
            string formapago = (Console.ReadLine()).ToLower();

            //en caso de ser tarjeta pedir el numero de tarjeta 
            if(formapago.Equals("tarjeta"))
            {
                Console.WriteLine("introduce el numero de tarjeta");
                int numero_tarjeta = Convert.ToInt32(Console.ReadLine());

            }
            //imprimir mensaje el producto con precio
            Console.WriteLine("el producto con precio"+ precio + "se ha pagado con el; numero de tarjeta"+  )
            //imprimir mensaje 
        }
    }
}

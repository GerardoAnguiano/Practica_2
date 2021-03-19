using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifchar
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 pedir por consola el caracter
            Console.WriteLine("Por favor escribe un caracter");
            char c = (char)Console.Read();
            if (char.IsLetter(c))
            {
                if (char.IsLower(c))
                {
                    Console.WriteLine("el caracter es letra minuscula");
                }
                else
                {
                    Console.WriteLine("el caracter es letra mayuscula");
                }
            }
            else
            {
                Console.WriteLine("el caracter es numero");
            }
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadKey();
        }

        


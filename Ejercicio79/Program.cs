using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio79
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            SortedSet<string> datos = new SortedSet<string>();

            Console.WriteLine("Ingrese una frase o ingrese ¨salir¨ para salir");
            cadena = Console.ReadLine();

            while (cadena != "salir")
            {
                if (datos.Contains(cadena))
                {
                    Console.WriteLine("Esa frase ya existe!");
                }
                datos.Add(cadena);
                Console.WriteLine("Ingrese la siguente frase o ingrese ¨salir¨ para salir");
                cadena = Console.ReadLine();
            }
        }
    }
}

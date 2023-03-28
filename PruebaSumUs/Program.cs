using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSumUs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra para saber si es palindromo: ");

            // Creamos la instancia a la clase Palindromo
            Palindromo pal = new Palindromo(GetInputString());

            // Validacion para saber si es palindromo o no
            if (pal.EsPalindromo())
                Console.WriteLine("Es palindromo");
            else
                Console.WriteLine("No es palindromo");

            // Para que no cierre la consola

            Console.ReadLine();
            
        }

        // Obtener el string del usuario
        public static string GetInputString() {

            string input = Console.ReadLine();

            return input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSumUs
{
    // Internal solo acecsible en el mismo assemlby
    internal class Palindromo
    {
        string str_palindromo;

        public Palindromo(string InputString) { 
        
            this.str_palindromo = InputString;
        
        }


        public bool EsPalindromo()
        {
            // 
            bool status = false;

            // Primer char array recibido del usuario
            char[] strarray = str_palindromo.ToCharArray();

            // Segundo char array donde vamos a guardar el string al reves
            char[] newarray = new char [str_palindromo.Length];
            
            for(int i = 0;i < str_palindromo.Length; i++)
            {
                // Recorremos del ultimo espacio al primero
                char aux = strarray[ (str_palindromo.Length - 1) - i]; 

                // Asignamos el ultimo char del string recibido al primer char del string auxiliar
                newarray[i] = aux;
            }

            // Creamos un nuevo string para hacer mas facil la comparacion
            string str_result = new string (newarray);

            if(str_palindromo.Equals(str_result))
                status = true;


            return status;

        }




    }
}

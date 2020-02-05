using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero1 = "";
            string numero2 = "";
            string individual = "";

            int tamaño = 0;
            

            Console.Write("Ingrese una palabra: ");
            numero1 = Console.ReadLine();
            tamaño = numero1.Length;

            for (int i = tamaño - 1; i >= 0; i--)
            {
                individual = numero1.Substring(i, 1);
                numero2 = numero2 + individual;
            }
            Console.WriteLine(numero1 +"-"+ numero2);

            Console.ReadLine();


        }
    }
}

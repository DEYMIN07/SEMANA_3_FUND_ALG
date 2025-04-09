using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;
            //Console.ReadKey();
            Console.Write("ingrese numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            // console.readline es igual a leer en pseint
            Console.Write("ingrese numero 2: ");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine("la suma es: " +suma);

        }
    }
}

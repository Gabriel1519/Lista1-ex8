using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C;
            double F;

            Console.Write("Insira a Temperatura em Graus Celsius: ");
            C = double.Parse(Console.ReadLine());

           F = (C * 9/5) + 32;

            Console.WriteLine("A Temperatura em fahrenheit é {0}.", F);
        }
    }
}

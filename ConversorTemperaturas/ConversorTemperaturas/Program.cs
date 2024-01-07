using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas {
    internal class Program {
        static void Main(string[] args) {
            double c, f, k;
            Console.WriteLine("Conversor de temperaturas");
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            f = (c * 9 / 5) + 32;
            k = c + 273.15;
            Console.WriteLine($"{c}º Celcius = {f}º Fahrenheit");
            Console.WriteLine($"{c}º Celcius = {k}º Kelvin");



        }
    }
}

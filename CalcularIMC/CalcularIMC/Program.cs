using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {

        static void Main ( string[] args )
        {
            Console.Write("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso /  Math.Pow(altura, 2);

            Console.WriteLine($"Seu IMC: {imc}");
            if( imc < 18.5 ) 
            {
                Console.WriteLine("Está classificado como: Magreza");
            }else if(imc < 24.9 )
            {
                Console.WriteLine("Está classificado como: Normal");
            }else if(imc < 29.9 )
            {
                Console.WriteLine("Está classificado como: Sobrepeso");
            }else if(imc < 39.9 )
            {
                Console.WriteLine("Está classificado como: Obesidade");
            }
            else
            {
                Console.WriteLine("Está classificado como: Obesidade grave");
            }

            Console.ReadKey();

        }
    }
}

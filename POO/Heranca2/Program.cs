using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Fastback", "Preto");
            CarroCombate cc1 = new CarroCombate( );

            c1.Ligar();

            Console.WriteLine($"Cor: {c1.cor}");
            Console.WriteLine($"Nome: {c1.nome}");
            Console.WriteLine($"Rodas: {c1.getRodas()}");
            Console.WriteLine($"Vel.Maxima: {c1.getVelMax( )}");
            Console.WriteLine($"Ligado: {c1.getLigado()}");

            Console.WriteLine();

            Console.WriteLine($"Cor: {cc1.cor}");
            Console.WriteLine($"Nome: {cc1.nome}");
            Console.WriteLine($"Rodas: {cc1.getRodas( )}");
            Console.WriteLine($"Vel.Maxima: {cc1.getVelMax( )}");
            Console.WriteLine($"Ligado: {cc1.getLigado( )}");
            Console.WriteLine($"Municao: {cc1.municao}");

            Console.ReadKey( );
        }
    }
}

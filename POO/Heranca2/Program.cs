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

            Console.WriteLine($"Cor: {c1.cor}");
            Console.WriteLine($"Nome: {c1.nome}");
            Console.WriteLine($"Rodas: {c1.rodas}");
            Console.WriteLine($"Vel.Maxima: {c1.velMax}");
        }
    }
}

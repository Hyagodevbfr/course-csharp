using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            int escolha = 4;
            switch (escolha)
            {
                default:
                    Console.WriteLine("Opção padrão");
                    break;
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Opção combinada");
                    break;
            }
            Console.ReadKey( );
        }
    }
}

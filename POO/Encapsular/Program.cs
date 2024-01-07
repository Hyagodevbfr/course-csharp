using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Cliente = "Hyago";
            //c.Saldo = 100;

            //DEPOSITAR
            double valor = 100;
            c.Depositar(valor);

            //SACAR
            double valor2 = 50;
            c.Sacar(valor2);

            //RESULTADO SALDO ATUAL

            Console.WriteLine($"Cliente: {c.Cliente}");
            Console.WriteLine($"Saldo: {c.Saldo}");

            Console.ReadKey( );

        }
    }
}

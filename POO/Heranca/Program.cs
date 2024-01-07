using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Bicicleta b1 = new Bicicleta();

            c1.Acelerar( );
            c1.Cor = "Preto";

        }
    }
}

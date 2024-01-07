using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            #region Ciclo while
            /*
            int valor = 12;
            while ( valor < 11 )
            {
                Console.WriteLine($"O valor é {valor}");
                valor++;
            }
            */
            #endregion

            #region Cilo do-while
            /*
            int valor = 15;
            do
            {
                Console.WriteLine($"O valor é: {valor}");
                valor++;
            } while ( valor < 11 );
            */
            #endregion

            #region Ciclo for
            /*
            for ( int i = 0, j = 10; i < 10; i++, j-- )
            {
                Console.WriteLine($"I = {i} | J = {j}");
            }
            */
            #endregion

            string[] nomes =
            {
               "Hyago",
               "Miguel",
               "Daniel",
               "Maria"
            };

            foreach ( string nome in nomes )
            {
                Console.WriteLine( nome );
            }

            Console.ReadKey( );
        }
    }
}

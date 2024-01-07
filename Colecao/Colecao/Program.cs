using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao {
    internal class Program {
        static void Main(string[] args) {
            #region array vetor
            /*
            int[] numeros = new int[5];
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            numeros[2] = 55;

            string[] nomes = { 
                "Hyago",
                "Daniel",
                "Miguel" 
            };
            */
            #endregion

            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write($"[{numeros[0, 0]}]");
            Console.Write($"[{numeros[0, 1]}]");
            Console.Write($"[{numeros[0, 2]}]");
            
            Console.WriteLine();
            
            Console.Write($"[{numeros[1, 0]}]");
            Console.Write($"[{numeros[1, 1]}]");
            Console.Write($"[{numeros[1, 2]}]");

            Console.WriteLine();

            string[,] nomes = {
                { "Hyago", "Daniel", "Tiago" },
                { "Miguel", "Samuel", "Maria" }
            };

            Console.Write($"[{nomes[0,0]}] [{nomes[0,1]}] [{nomes[0,2]}]");
            Console.WriteLine();
            Console.Write($"[{nomes[1, 0]}] [{nomes[1, 1]}] [{nomes[1, 2]}]");

            Console.ReadKey();
        }
    }
}
 
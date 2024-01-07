using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacao op = new Operacao();
            double operador1, operador2;
            char operacao, continuar;
            do
            {
                Console.Clear();
                Console.Write("Insira o primeiro valor: ");
                operador1 = double.Parse(Console.ReadLine( ));

                Console.Write("Insira o segundo valor: ");
                operador2 = double.Parse(Console.ReadLine( ));

                Console.Write("Escolha a operação ( + - x / ): ");
                operacao = char.Parse(Console.ReadLine( ));

                op.operacaoResultado(operacao,operador1,operador2);

                Console.WriteLine("Deseja continuar (s/n)?");
                continuar = char.Parse(Console.ReadLine( ));

            } while(continuar == 's' || continuar == 'S');
        }
    }
}

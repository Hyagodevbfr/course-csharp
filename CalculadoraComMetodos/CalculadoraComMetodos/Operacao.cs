using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComMetodos
{
    internal class Operacao
    {
        public void operacaoResultado(char operacao,double op1,double op2)
        {
            double resultado;

            switch(operacao)
            {
                default:
                Console.WriteLine("Erro, opção inválida");
                break;

                case '+':
                resultado = op1 + op2;
                Console.WriteLine($"O resultado da soma é: {resultado}");
                break;

                case '-':
                resultado = op1 - op2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                break;

                case '*':
                case 'x':
                case 'X':
                resultado = op1 * op2;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                break;

                case '/':
                case ':':
                if(op2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir por 0.");
                }
                else
                {
                    resultado = op1 / op2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                }
                break;

            }
        }
    }
}

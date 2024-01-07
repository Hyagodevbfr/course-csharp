using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe estatica
            /*
            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            */
            #endregion

            #region Membros estáticos
            
            Pessoa.maiorIdade = 21;

            Pessoa p1 = new Pessoa();

            p1.nome = "Hyago";
            p1.idade = Pessoa.CalcularIdade(1999);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maiorIdade);
           
            #endregion

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            #region Classes e Objetos
            MinhaClasse mCLasse = new MinhaClasse ();
            MinhaClasse m2 = null;

            OutraClasse oClasse = new OutraClasse ();
            OutraClasse outra2 = oClasse;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Hyago";
            p1.sobrenome = "Brito";
            p1.anoNasc = 1999;

            Pessoa p2 = new Pessoa( ) 
            { 
                nome = "Miguel",
                sobrenome = "Brito",
                anoNasc = 2013
            };

            p1.sobrenome = "Nascimento";

            Console.WriteLine($"Pessoa 1: {p1.nome}");
            Console.WriteLine($"Pessoa 1: {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p1.anoNasc}");
            p1.Cumprimentar( );

            Console.WriteLine();

            Console.WriteLine($"Pessoa 2: {p2.nome}");
            Console.WriteLine($"Pessoa 2: {p2.sobrenome}");
            Console.WriteLine($"Pessoa 2: {p2.anoNasc}");
            p2.Cumprimentar( );



            Console.ReadKey();
        }
    }

    class MinhaClasse
    {
        
    }

}

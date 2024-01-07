using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        //Atributos / campos(field)
        public string nome;
        public string sobrenome;
        public int anoNasc;

        //Metodo simples
        public void Cumprimentar() 
        {
            Console.WriteLine($"Olá, me chamo {nome} {sobrenome}, nasci em {anoNasc}");
        }
    }
}

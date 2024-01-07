using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis {
    internal class Program {

        struct Pessoa {
            public string nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa();
            p1.nome = "Hyago";
            p1.idade = 24;
            p1.altura = 1.80;

            Pessoa pessoa = new Pessoa() {
                nome = "Miguel",
                idade = 10,
                altura = 1.65
            };

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    internal class Carro: Veiculo
    {//Classe derivada
        public string nome;
        public string cor;
        public Carro(string nome, string cor) 
        {
            Desligar();
            rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }
}

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
        public Carro(string nome, string cor): base(4, 150) 
        {
            Desligar();
            setRodas(4);
            setVelMax(150);
            
            this.nome = nome;
            this.cor = cor;
        }
    }
}

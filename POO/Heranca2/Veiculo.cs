using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    internal class Veiculo
    {//Classe base
        public int rodas;
        public int velMax;
        private bool ligado;
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return (ligado ? "Sim" : "Não");
        }
    }
}

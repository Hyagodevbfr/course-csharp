using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    internal class Veiculo
    {//Classe base
        private int rodas;
        private int velMax;
        private bool ligado;

        public Veiculo(int rodas, int velMax)
        {
            this.rodas = rodas;
            this.velMax = velMax;
            
        }
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
        public int getRodas()
        {
            return rodas;
        }

        public int getVelMax()
        {
            return velMax;
        }

        public void setRodas(int rodas)
        {
            if(rodas < 0)
            {
                this.rodas = 0;
            }else if(rodas > 40) 
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
        public void setVelMax(int velMax) 
        {
            if(velMax < 0)
            {
                this.velMax = 0;
            }
            else if (velMax > 220)
            {
                this.velMax = 220;
            }
            else
            {
                this.velMax = velMax;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca2
{
    internal class CarroCombate: Carro
    {
        public int municao;
        public CarroCombate(): base("Matador", "Verde")
        {
            municao = 100;
            setRodas(6);
            setVelMax(200);
            
        }
    }
}

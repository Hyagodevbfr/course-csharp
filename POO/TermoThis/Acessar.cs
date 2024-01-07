using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        string senha = "abc123";
        
        public bool login(string senha)
        {
            return senha == senha;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Carro : Duravel
    {
        public String Marca { set; get; }
        public String Modelo { set; get; }

        public Carro() { }
    }
}

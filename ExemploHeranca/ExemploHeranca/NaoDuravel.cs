using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class NaoDuravel : Produto
    {
        public DateTime Validade { set; get; }

        public NaoDuravel() { }
    }
}

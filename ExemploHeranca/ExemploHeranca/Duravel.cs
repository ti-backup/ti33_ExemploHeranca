using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Duravel : Produto
    {
        public DateTime Venda { set; get; }
        public Int32 MesesGarantia { set; get; }

        public Duravel()
        {
            MesesGarantia = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Produto
    {
        public Int32 Id { private set; get; }
        public String Nome { set; get; }
        public String Descricao { set; get; }
        public Double Preco { set; get; }

        public Produto()
        {
            Nome = "Desconhecido";
            Preco = 0;
        }

        public void BuscaProdutosPorNome()
        {
            // CONSULTA SQL
            Id = 8;
        }
    }
}

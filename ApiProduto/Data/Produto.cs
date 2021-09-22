using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProduto.Data
{
    public class Produto
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public decimal Valor  { get; set; }

        public int Estoque { get; set; }
    }
}

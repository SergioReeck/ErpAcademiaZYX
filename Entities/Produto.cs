using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public double ValorCusto { get; set; }
        public double ValorVenda { get; set; }
        public int Estoque { get; set; }
    }
}

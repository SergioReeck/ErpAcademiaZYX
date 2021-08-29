using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntradaProduto
    {
        public int ID { get; set; }
        public DateTime DataEntrada{ get; set; }
        public int Credencial{ get; set; }
        public double Total { get; set; }
        public List<ItemEntrada> Items { get; set; }
    }
}

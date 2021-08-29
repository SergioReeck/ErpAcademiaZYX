using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VendaProduto
    {
        public int ID { get; set; }
        public DateTime DataVenda { get; set; }
        public int Cliente { get; set; }
        public int Credencial { get; set; }
        public double Total { get; set; }
        public List<ItemVenda> Items { get; set; }
    }
}

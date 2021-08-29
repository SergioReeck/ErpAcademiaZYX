using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IProduto
    {
        Response Insert(Produto p);
        Response Update(Produto p);
        Response Delete(int id);
        DataResponse<Produto> GetAll();
    }
}

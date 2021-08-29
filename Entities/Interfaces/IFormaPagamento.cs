using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IFormaPagamento
    {
        Response Insert(FormaPagamento fp);
        Response Update(FormaPagamento fp);
        DataResponse<FormaPagamento> GetAll();
    }
}

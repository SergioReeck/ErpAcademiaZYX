using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ICredencial
    {
        SingleResponse<Credencial> Authenticate(string email, string senha);
        Response Insert(Credencial c);
        Response Update(Credencial c);
        DataResponse<Credencial> GetAll();
    }
}

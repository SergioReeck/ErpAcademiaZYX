using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class CredencialBLL : BaseValidator<Credencial>, ICredencial
    {
        private CredencialDAL credencialDAL = new CredencialDAL();

        public override Response Validate(Credencial item)
        {
            return base.Validate(item);
        }

        public SingleResponse<Credencial> Authenticate(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                this.AddError("E-mail deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                this.AddError("Senha deve ser informada.");
            }

            Response response = base.Validate(null);
            
            if (response.Success)
            {
                SingleResponse<Credencial> responseCredencial = credencialDAL.Authenticate(email, senha);
                if (responseCredencial.Success)
                {
                    SystemParameters.Authenticate(responseCredencial.Item);
                }
                return responseCredencial;
            }

            return new SingleResponse<Credencial>()
            {
                Message = response.Message,
                Success = false
            };
        }

        public Response Insert(Credencial credencial)
        {
            Response response = this.Validate(credencial);
            if (!response.Success)
            {
                return response;
            }
            return credencialDAL.Insert(credencial);
        }

        public Response Update(Credencial credencial)
        {
            Response response = this.Validate(credencial);
            if (!response.Success)
            {
                return response;
            }
            return credencialDAL.Update(credencial);
        }

        public DataResponse<Credencial> GetAll()
        {
            return credencialDAL.GetAll();
        }
    }
}

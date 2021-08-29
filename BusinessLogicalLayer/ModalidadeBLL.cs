using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogicalLayer
{
    
    public class ModalidadeBLL : BaseValidator<Modalidade>, IModalidade
    {
        private ModalidadeDAL modalidadeDAL = new ModalidadeDAL();

        public override Response Validate(Modalidade item)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
            {
                this.AddError("Modalidade deve ser informada.");
            }
            else
            {
                item.Descricao = Normatization.NormatizeString(item.Descricao);
                if (item.Descricao.Length < 3 || item.Descricao.Length > 15)
                {
                    this.AddError("Modalidade deve conter entre 3 e 15 caracteres.");
                }
            }
            if (item.Valor <= 0)
            {
                this.AddError("O valor deve ser informado.");
            }
            return base.Validate(item);
        }

        public DataResponse<Modalidade> GetAll()
        {
            return modalidadeDAL.GetAll();
        }

        public Response Insert(Modalidade modalidade)
        {
            Response response = this.Validate(modalidade);

            if (!response.Success)
            {
                return response;
            }
            return modalidadeDAL.Insert(modalidade);
        }

        public Response Update(Modalidade modalidade)
        {
            Response response = this.Validate(modalidade);
            
            if (!response.Success)
            {
                return response;
            }
            return modalidadeDAL.Update(modalidade);
        }

        public Response Delete(int id)
        {
            return modalidadeDAL.Delete(id);
        }
    }
}

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
    public class FormaPagamentoBLL : BaseValidator<FormaPagamento>, IFormaPagamento
    {
        private FormaPagamentoDAL formaDePagamentoDAL = new FormaPagamentoDAL();

        public override Response Validate(FormaPagamento item)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
            {
                this.AddError("Forma de pagamento deve ser informada.");
            }
            else
            {
                item.Descricao = Normatization.NormatizeString(item.Descricao);
                if (item.Descricao.Length < 3 || item.Descricao.Length > 20)
                {
                    this.AddError("Forma de pagamento deve conter entre 3 e 20 caracteres.");
                }
            }
            return base.Validate(item);
        }

        public DataResponse<FormaPagamento> GetAll()
        {
            return formaDePagamentoDAL.GetAll();
        }

        public Response Insert(FormaPagamento formaDePagamento)
        {
            Response response = this.Validate(formaDePagamento);
            if (!response.Success)
            {
                return response;
            }
            return formaDePagamentoDAL.Insert(formaDePagamento);
        }

        public Response Update(FormaPagamento formaDePagamento)
        {
            Response response = this.Validate(formaDePagamento);
            if (!response.Success)
            {
                return response;
            }
            return formaDePagamentoDAL.Update(formaDePagamento);
        }
    }
}

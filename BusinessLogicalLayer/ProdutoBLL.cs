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
    public class ProdutoBLL : BaseValidator<Produto>, IProduto
    {
        private ProdutoDAL produtoDAL= new ProdutoDAL();

        public override Response Validate(Produto item)
        {
            return base.Validate(item);
        }
        public DataResponse<Produto> GetAll()
        {
            return produtoDAL.GetAll();
        }

        public Response Insert(Produto produto)
        {
            Response response = this.Validate(produto);
            if (!response.Success)
            {
                return response;
            }
            return produtoDAL.Insert(produto);
        }

        public Response Update(Produto produto)
        {
            Response response = this.Validate(produto);
            if (!response.Success)
            {
                return response;
            }
            return produtoDAL.Update(produto);
        }

        public Response Delete(int id)
        {
            return produtoDAL.Delete(id);
        }

        public DataResponse<Produto> PesquisarProduto(Produto produto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            return produtoDAL.PesquisarProduto(produto);
        }
    }
}

using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class VendaProdutoBLL : IVendaProduto
    {
        private VendaProdutoDAL vendaProdutoDAL = new VendaProdutoDAL();
        private ProdutoDAL produtoDAL = new ProdutoDAL();

        public Response RegistrarVenda(VendaProduto vendaProduto)
        {
            vendaProduto.DataVenda = DateTime.Now;
            vendaProduto.Total = vendaProduto.Items.Sum(c => c.Quantidade * c.Valor);
            vendaProduto.Credencial = SystemParameters.GetCurrrentCredencial().ID;

            using (TransactionScope scope = new TransactionScope())
            {
                Response response = vendaProdutoDAL.RegistrarVenda(vendaProduto);
                if (!response.Success)
                {
                    return response;
                }

                foreach (ItemVenda itemVenda in vendaProduto.Items)
                {
                    itemVenda.Venda = vendaProduto.ID;
                    Response responseItem = vendaProdutoDAL.RegistrarItemVenda(itemVenda);
                    if (!responseItem.Success)
                    {
                        return responseItem;
                    }

                    SingleResponse<Produto> responseProduto = produtoDAL.GetByID(itemVenda.Produto);
                    if (!responseProduto.Success)
                    {
                        return responseProduto;
                    }

                    Produto p = responseProduto.Item;

                    int novoEstoque = p.Estoque - itemVenda.Quantidade;

                    p.Estoque = novoEstoque;

                    Response responseUpdateProduto = produtoDAL.Update(p);

                    if (!responseUpdateProduto.Success)
                    {
                        return responseUpdateProduto;
                    }
                }
                scope.Complete();
                return response;
            }
        }
    }
}

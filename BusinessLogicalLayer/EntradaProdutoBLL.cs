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
    public class EntradaProdutoBLL : IEntradaProduto
    {
        private EntradaProdutoDAL entradaProdutoDAL = new EntradaProdutoDAL();
        private ProdutoDAL produtoDAL = new ProdutoDAL();

        public Response RegistrarEntrada(EntradaProduto entradaProduto)
        {
            entradaProduto.DataEntrada = DateTime.Now;
            entradaProduto.Total = entradaProduto.Items.Sum(c => c.Quantidade * c.Valor);
            entradaProduto.Credencial = SystemParameters.GetCurrrentCredencial().ID;

            using (TransactionScope scope = new TransactionScope())
            {
                Response response = entradaProdutoDAL.RegistrarEntrada(entradaProduto);
                if (!response.Success)
                {
                    return response;
                }

                foreach (ItemEntrada itemEntrada in entradaProduto.Items)
                {
                    itemEntrada.Entrada = entradaProduto.ID;
                    Response responseItem = entradaProdutoDAL.RegistrarItemEntrada(itemEntrada);
                    if (!responseItem.Success)
                    {
                        return responseItem;
                    }

                    SingleResponse<Produto> responseProduto = produtoDAL.GetByID(itemEntrada.Produto);
                    if (!responseProduto.Success)
                    {
                        return responseProduto;
                    }

                    Produto p = responseProduto.Item;

                    int novoEstoque = itemEntrada.Quantidade + p.Estoque;
                    double novoPreco = ((itemEntrada.Quantidade * itemEntrada.Valor) + (p.Estoque * p.ValorCusto)) / (p.Estoque + itemEntrada.Quantidade);

                    p.ValorCusto = novoPreco;
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

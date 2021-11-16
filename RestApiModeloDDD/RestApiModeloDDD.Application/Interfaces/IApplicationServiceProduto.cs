using RestApiModeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces
{
   public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto obj);
        void Update(ProdutoDto obj);
        void Remove(ProdutoDto obj);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);
    }
}

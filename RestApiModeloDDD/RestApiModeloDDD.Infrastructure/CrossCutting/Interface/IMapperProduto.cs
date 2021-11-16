using RestApiModeloDDD.Application.Dtos;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interface
{
   public interface IMapperProduto
    {
        Produto MapperDtoEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListClienteDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}


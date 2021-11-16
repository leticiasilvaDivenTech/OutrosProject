using RestApiModeloDDD.Application.Dtos;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Mappers.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}

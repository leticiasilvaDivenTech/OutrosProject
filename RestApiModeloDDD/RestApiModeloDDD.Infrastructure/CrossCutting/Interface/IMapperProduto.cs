using RestApiModeloDDD.Application.Dtos;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interface
{
   public interface IMapperProduto
    {
        Produto MapperDtoEntity(ProdutoDto clienteDto);
        IEnumerable<ProdutoDto> MapperListClienteDto(IEnumerable<Produto> clientes);
        ProdutoDto MapperEntityToDto(Produto cliente);
    }
}


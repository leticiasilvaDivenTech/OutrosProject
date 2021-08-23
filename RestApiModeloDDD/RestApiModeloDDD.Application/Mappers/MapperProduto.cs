using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Application.Mappers
{
   public class MapperProduto : IMapperProduto
    {
        List<ProdutoDto> ProdutoDtos = new List<ProdutoDto>();
        public Produto MapperDtoEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id.Value,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor,


            };
            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> clientes)
        {
            var dto = clientes.Select(c => new ProdutoDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Valor = c.Valor
            });
            return dto;
        }
    }
}

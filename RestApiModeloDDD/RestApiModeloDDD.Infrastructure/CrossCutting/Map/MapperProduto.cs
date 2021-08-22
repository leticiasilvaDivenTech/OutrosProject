using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Map
{
    public class MapperProduto : IMapperProduto
    {
        List<ProdutoDto> ClientesDtos = new List<ProdutoDto>();
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

        public IEnumerable<ProdutoDto> MapperListClienteDto(IEnumerable<Produto> clientes)
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

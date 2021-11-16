using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        public readonly IServiceProduto serviceProduto;
        public readonly IMapperProduto mapperProduto;
        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }
        public void Add(ProdutoDto obj)
        {
            var clienteDto = mapperProduto.MapperDtoEntity(obj);
            serviceProduto.Add(clienteDto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var cliente = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutoDto(cliente);

        }

        public ProdutoDto GetById(int id)
        {
            var cliente = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(cliente);
        }

        public void Remove(ProdutoDto obj)
        {
            var cliente = mapperProduto.MapperDtoEntity(obj);
            serviceProduto.Remove(cliente);
        }

        public void Update(ProdutoDto obj)
        {
            var cliente = mapperProduto.MapperDtoEntity(obj);
            serviceProduto.Update(cliente);
        }
    }
}

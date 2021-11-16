using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        public readonly IServiceCliente serviceCliente;
        public readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }
        public void Add(ClienteDto obj)
        {
            var clienteDto = mapperCliente.MapperDtoEntity(obj);
            serviceCliente.Add(clienteDto);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var cliente = serviceCliente.GetAll();
            return mapperCliente.MapperListClienteDto(cliente);

        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto obj)
        {
            var cliente = mapperCliente.MapperDtoEntity(obj);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto obj)
        {
            var cliente = mapperCliente.MapperDtoEntity(obj);
            serviceCliente.Update(cliente);
        }
    }
}

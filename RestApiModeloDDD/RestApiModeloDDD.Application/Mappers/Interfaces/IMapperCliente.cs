using RestApiModeloDDD.Application.Dtos;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Mappers.Interfaces
{
   public interface IMapperCliente
    {
        Cliente MapperDtoEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}

using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interface;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Map
{
    public class MapperCliente : IMapperCliente
    {

        List<ClienteDto> ClientesDtos = new List<ClienteDto>();
        public Cliente MapperDtoEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id.Value,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email,
                Datacadastro = ""

            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email
            });
            return dto;
        }
    }
}

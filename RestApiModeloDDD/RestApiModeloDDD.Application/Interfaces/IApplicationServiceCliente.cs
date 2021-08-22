using RestApiModeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto obj);
        void Update(ClienteDto obj);
        void Remove(ClienteDto obj);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);
    }
}

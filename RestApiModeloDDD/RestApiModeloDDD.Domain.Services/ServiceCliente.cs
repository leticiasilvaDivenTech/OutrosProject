using RestApiModeloDDD.Domain.core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente 
    {

        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente repositoryCliente) :base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}

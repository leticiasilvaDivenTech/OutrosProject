using RestApiModeloDDD.Domain.core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
   public  class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
        }
    }
}

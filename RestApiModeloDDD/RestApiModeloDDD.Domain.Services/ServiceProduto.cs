using RestApiModeloDDD.Domain.core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
   public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}

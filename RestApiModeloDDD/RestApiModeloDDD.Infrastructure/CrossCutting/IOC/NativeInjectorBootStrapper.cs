using Microsoft.Extensions.DependencyInjection;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Mappers;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
   public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            #region
            service.AddScoped<IApplicationServiceCliente, ApplicationServiceCliente>();
            service.AddScoped<IApplicationServiceProduto, ApplicationServiceProduto>();
            service.AddScoped<IServiceCliente, ServiceCliente>();
            service.AddScoped<IServiceProduto, ServiceProduto>();
            service.AddScoped<IRepositoryCliente, RepositoryCliente>();
            service.AddScoped<IRepositoryProduto, RepositoryProduto>();
            service.AddScoped<IMapperCliente, MapperCliente>();
            service.AddScoped<IMapperProduto, MapperProduto>();
            #endregion
        }
    }
}

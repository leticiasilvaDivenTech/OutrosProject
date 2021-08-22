using RestApiModeloDDD.Domain.core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            this.repository = repository;
        }
        public void Add(T obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
           return repository.GetAll();
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(T obj)
        {
            repository.Remove(obj);
        }

        public void Update(T obj)
        {
            repository.Update(obj);
        }
    }
}

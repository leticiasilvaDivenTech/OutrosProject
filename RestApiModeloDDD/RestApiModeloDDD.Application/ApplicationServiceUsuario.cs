using RestApiModeloDDD.Application.Dtos.Usuario;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestApiModeloDDD.Domain.core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        public readonly IServiceUsuario serviceUsuario;
        public readonly IMapperUsuario mapperUsuario;
        public ApplicationServiceUsuario(IServiceUsuario serviceUsuario, IMapperUsuario mapperUsuario)
        {
            this.serviceUsuario = serviceUsuario;
            this.mapperUsuario = mapperUsuario;
        }
        public void Add(UsuarioDto obj)
        {
            var usuarioDto = mapperUsuario.MapperDtoEntity(obj);
            serviceUsuario.Add(usuarioDto);
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            var usuario = serviceUsuario.GetAll();
            return mapperUsuario.MapperListUsuarioDto(usuario);
        }

        public UsuarioDto GetById(int id)
        {
            var usuario = serviceUsuario.GetById(id);
            return mapperUsuario.MapperEntityToDto(usuario);
        }

        public void Remove(UsuarioDto obj)
        {
            var usuario = mapperUsuario.MapperDtoEntity(obj);
            serviceUsuario.Remove(usuario);
        }

        public void Update(UsuarioDto obj)
        {
            var usuario = mapperUsuario.MapperDtoEntity(obj);
            serviceUsuario.Update(usuario);
        }
    }
}

using RestApiModeloDDD.Application.Dtos.Usuario;
using RestApiModeloDDD.Application.Mappers.Interfaces;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Map
{
    public class MapperUsuario : IMapperUsuario
    {
        List<UsuarioDto> UsuarioDtos = new List<UsuarioDto>();
        public Usuario MapperDtoEntity(UsuarioDto usuarioDto)
        {
            var usuario = new Usuario()
            {
                Id = usuarioDto.Id.Value,
                Nome = usuarioDto.Nome,
                Senha = usuarioDto.Senha,
                Email = usuarioDto.Email


            };
            return usuario;
        }

        public UsuarioDto MapperEntityToDto(Usuario usuario)
        {
            var usuarioDto = new UsuarioDto()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Senha = usuario.Senha,
                Email = usuario.Email
            };
            return usuarioDto;
        }

        public IEnumerable<UsuarioDto> MapperListUsuarioDto(IEnumerable<Usuario> usuarios)
        {
            var dto = usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                Nome = u.Nome,
                Senha = u.Senha,
                Email = u.Email
            });
            return dto;
        }
    }
}

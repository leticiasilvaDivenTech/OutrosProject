using RestApiModeloDDD.Application.Dtos.Usuario;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Mappers.Interfaces
{
   public interface IMapperUsuario
    {
        Usuario MapperDtoEntity(UsuarioDto usuarioDto);
        IEnumerable<UsuarioDto> MapperListUsuarioDto(IEnumerable<Usuario> usuarios);
        UsuarioDto MapperEntityToDto(Usuario usuario);
    }
}

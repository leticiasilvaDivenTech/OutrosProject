using RestApiModeloDDD.Application.Dtos.Usuario;
using RestAPiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Interface
{
    public interface IMapperUsuario
    {
        Usuario MapperDtoEntity(UsuarioDto usuarioDto);
        IEnumerable<UsuarioDto> MapperListUsuarioDto(IEnumerable<Usuario> usuario);
        UsuarioDto MapperEntityToDto(Usuario usuario);
    }
}

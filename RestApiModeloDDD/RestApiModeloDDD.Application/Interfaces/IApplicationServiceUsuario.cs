using RestApiModeloDDD.Application.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceUsuario 
    {
        void Add(UsuarioDto obj);
        void Update(UsuarioDto obj);
        void Remove(UsuarioDto obj);
        IEnumerable<UsuarioDto> GetAll();
        UsuarioDto GetById(int id);
    }
}

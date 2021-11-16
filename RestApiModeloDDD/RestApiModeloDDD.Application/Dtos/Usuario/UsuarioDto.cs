using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Dtos.Usuario
{
   public class UsuarioDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}

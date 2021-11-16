using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Domain.Entitys
{
  public class Usuario  : Base
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
      
    }
}

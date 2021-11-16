using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Dtos
{
   public class ProdutoDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

    }
}

using System;

namespace RestAPiModeloDDD.Domain.Entitys
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Datacadastro { get; set; }
        public bool IsAtivo { get; set; }
        
    }
}

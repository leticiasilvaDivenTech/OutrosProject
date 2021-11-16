
namespace RestAPiModeloDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public bool IsDisponivel { get; set; }

    }
}

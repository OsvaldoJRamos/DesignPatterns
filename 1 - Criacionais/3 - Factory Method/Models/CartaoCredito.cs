using DesignPatterns._1___Criacionais._3___Factory_Method;
namespace DesignPatterns
{
    public abstract class CartaoCredito
    {
        public string Tipo { get; protected set; }
        public int LimiteInicial { get; protected set; }
    }
}

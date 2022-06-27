using DesignPatterns._1___Criacionais._3___Factory_Method;
namespace DesignPatterns
{
    public class Black : CartaoCredito
    {
        public Black()
        {
            Tipo = "black";
            LimiteInicial = 100000;
        }
    }
}

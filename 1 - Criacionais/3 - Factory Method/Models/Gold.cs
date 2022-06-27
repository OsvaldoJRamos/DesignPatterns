using DesignPatterns._1___Criacionais._3___Factory_Method;
namespace DesignPatterns
{
    public class Gold : CartaoCredito
    {
        public Gold()
        {
            Tipo = "gold";
            LimiteInicial = 1000;
        }
    } 
}

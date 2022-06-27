namespace DesignPatterns._1___Criacionais._3___Factory_Method
{
    public class CartaoBlackFactory : CartaoCreditoFactory
    {
        protected override CartaoCredito FazerCartao()
        {
            var cartao = new Black();
            return cartao;
        }
    }
}

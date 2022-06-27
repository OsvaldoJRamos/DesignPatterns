namespace DesignPatterns._1___Criacionais._3___Factory_Method
{
    public class CartaoGoldFactory : CartaoCreditoFactory
    {
        protected override CartaoCredito FazerCartao()
        {
            var cartao = new Gold();
            return cartao;
        }
    } 
}

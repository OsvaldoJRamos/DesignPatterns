namespace DesignPatterns._1___Criacionais._3___Factory_Method
{
    public abstract class CartaoCreditoFactory
    {
        protected abstract CartaoCredito FazerCartao();
        public CartaoCredito CriarCartao()
        {
            return this.FazerCartao();
        }
    }
}

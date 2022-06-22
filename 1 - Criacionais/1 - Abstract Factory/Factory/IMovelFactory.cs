namespace DesignPatterns
{
    public interface IMovelFactory
    {
        Cadeira CriarCadeira();
        Mesa CriarMesa();
    }
}

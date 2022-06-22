namespace DesignPatterns
{
    public class MovelModernoFactory : IMovelFactory
    {
        public Cadeira CriarCadeira()
        {
            return new CadeiraModerna();
        }

        public Mesa CriarMesa()
        {
            return new MesaModerna();
        }
    }
}

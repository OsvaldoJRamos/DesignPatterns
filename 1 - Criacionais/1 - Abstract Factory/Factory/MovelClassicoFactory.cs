namespace DesignPatterns
{
    public class MovelClassicoFactory : IMovelFactory
    {
        public Cadeira CriarCadeira()
        {
            return new CadeiraCassica();
        }

        public Mesa CriarMesa()
        {
            return new MesaClassica();
        }
    }  
}

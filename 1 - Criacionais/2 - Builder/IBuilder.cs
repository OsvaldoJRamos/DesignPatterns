namespace DesignPatterns._1___Criacionais._2___Builder
{
    public interface IBuilder
    {
        public IBuilder SetQuantidadePortas(short quantidadePortas);
        public IBuilder SetQuantidadeBancos(short quantidadeBancos);
        public IBuilder SetCCMotor(short carroComum);
    }
}

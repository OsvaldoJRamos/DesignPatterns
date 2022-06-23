namespace DesignPatterns._1___Criacionais._2___Builder
{
    public class Carro
    {
        public int Motor { get; private set; }
        public short QuantidadeBancos { get; private set; }
        public short QuantidadePortas { get; private set; }

        public Carro()
        {

        }

        public void SetCCMotor(short motor)
        {
            Motor = motor;
        }

        public void SetQuantidadeBancos(short quantidadeBancos)
        {
            QuantidadeBancos = quantidadeBancos;
        }

        public void SetQuantidadePortas(short quantidadePortas)
        {
            QuantidadePortas = quantidadePortas;
        }
    }
}

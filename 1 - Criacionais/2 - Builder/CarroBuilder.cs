namespace DesignPatterns._1___Criacionais._2___Builder
{
    public class CarroBuilder : IBuilder
    {
        private Carro _carro = new Carro();

        public CarroBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _carro = new Carro();
        }

        public Carro GetCarro()
        {
            var carro = _carro;

            this.Reset();

            return carro;
        }

        public IBuilder SetCCMotor(short motor)
        {
            _carro.SetCCMotor(motor);
            return this;
        }

        public IBuilder SetQuantidadeBancos(short quantidadeBancos)
        {
            _carro.SetQuantidadeBancos(quantidadeBancos);
            return this;
        }

        public IBuilder SetQuantidadePortas(short quantidadePortas)
        {
            _carro.SetQuantidadePortas(quantidadePortas);
            return this;
        }
    }
}

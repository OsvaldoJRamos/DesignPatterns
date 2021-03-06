namespace DesignPatterns._1___Criacionais._2___Builder
{
    public class Director
    {
        private IBuilder _builder { get; set; }

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCarroEsportivo()
        {
            _builder
                .SetQuantidadeBancos(2)
                .SetQuantidadePortas(2)
                .SetCCMotor(1000);
        }

        public void BuildCarroComum()
        {
            _builder
                .SetQuantidadeBancos(5)
                .SetQuantidadePortas(4)
                .SetCCMotor(100);
        }
    }
}

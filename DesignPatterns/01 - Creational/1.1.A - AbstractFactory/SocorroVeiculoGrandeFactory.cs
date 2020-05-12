namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        private const Porte PORTE_GRANDE = Porte.Grande;

        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(PORTE_GRANDE);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return VeiculoCreator.Criar(modelo, PORTE_GRANDE);
        }
    }
}

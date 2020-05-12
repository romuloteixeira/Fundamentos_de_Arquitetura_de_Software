namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Concrete Factory
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        private const Porte PORTE_GRANDE = Porte.Grande;

        public override Guincho CriarGuincho()
        {
            return Guincho.Criar(PORTE_GRANDE);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return Veiculo.Criar(modelo, PORTE_GRANDE);
        }
    }
}

namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Concrete Factory
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        private const Porte PORTE_PEQUENO = Porte.Pequeno;

        public override Guincho CriarGuincho()
        {
            return Guincho.Criar(PORTE_PEQUENO);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return Veiculo.Criar(modelo, PORTE_PEQUENO);
        }
    }
}

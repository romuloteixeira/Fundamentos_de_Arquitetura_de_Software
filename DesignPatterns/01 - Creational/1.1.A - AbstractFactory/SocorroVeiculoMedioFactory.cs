namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Concrete Factory
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        private const Porte PORTE_MEDIO = Porte.Medio;

        public override Guincho CriarGuincho()
        {
            return Guincho.Criar(PORTE_MEDIO);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return Veiculo.Criar(modelo, PORTE_MEDIO);
        }
    }
}

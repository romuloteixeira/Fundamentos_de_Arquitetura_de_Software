namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class SocorroVeiculoMedioFactory : AutoSocorroFactory
    {
        private const Porte PORTE_MEDIO = Porte.Medio;

        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(PORTE_MEDIO);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return VeiculoCreator.Criar(modelo, PORTE_MEDIO);
        }
    }
}

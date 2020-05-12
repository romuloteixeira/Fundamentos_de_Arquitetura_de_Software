namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroFactory
    {
        private const Porte PORTE_PEQUENO = Porte.Pequeno;

        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Criar(PORTE_PEQUENO);
        }

        public override Veiculo CriarVeiculo(string modelo)
        {
            return new VeiculoPequeno(modelo);
        }
    }
}

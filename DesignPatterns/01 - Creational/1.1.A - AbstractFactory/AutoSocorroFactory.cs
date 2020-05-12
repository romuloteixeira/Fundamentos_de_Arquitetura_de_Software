namespace DesignPatterns.Creational.AbstractFactory11A
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();

        public abstract Veiculo CriarVeiculo(string modelo);
    }
}

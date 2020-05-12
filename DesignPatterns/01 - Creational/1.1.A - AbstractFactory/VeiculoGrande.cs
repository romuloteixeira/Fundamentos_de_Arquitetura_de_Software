namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class VeiculoGrande : Veiculo
    {
        private const Porte porteGrande = Porte.Grande;

        public VeiculoGrande(string modelo) : base(modelo, porteGrande)
        {
        }
    }
}

namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class VeiculoMedio : Veiculo
    {
        private const Porte porteMedio = Porte.Medio;

        public VeiculoMedio(string modelo) : base(modelo, porteMedio)
        {
        }
    }
}

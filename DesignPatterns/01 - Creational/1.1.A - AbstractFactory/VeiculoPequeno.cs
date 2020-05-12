namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class VeiculoPequeno : Veiculo
    {
        private const Porte portePequeno = Porte.Pequeno;

        public VeiculoPequeno(string modelo) : base(modelo, portePequeno)
        {
        }
    }
}

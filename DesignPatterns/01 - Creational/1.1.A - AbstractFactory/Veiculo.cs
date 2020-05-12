namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Abstract Product
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; protected set; }
        public Porte Porte { get; protected set; }
    }
}

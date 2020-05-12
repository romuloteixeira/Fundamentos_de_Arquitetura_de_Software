namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Abstract Product
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public Porte Porte { get; protected set; }

        public abstract void Socorrer(Veiculo veiculo);
    }
}

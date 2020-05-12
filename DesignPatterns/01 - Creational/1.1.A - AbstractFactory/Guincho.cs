using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Abstract Product
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public static Guincho Criar(Porte porte)
        {
            return porte switch
            {
                Porte.Grande => new GuinchoGrande(),
                Porte.Medio => new GuinchoMedio(),
                Porte.Pequeno => new GuinchoPequeno(),
                _ => throw new NotImplementedException("Porte não implementado para o guincho."),
            };
        }

        public Porte Porte { get; protected set; }

        public abstract void Socorrer(Veiculo veiculo);
    }
}

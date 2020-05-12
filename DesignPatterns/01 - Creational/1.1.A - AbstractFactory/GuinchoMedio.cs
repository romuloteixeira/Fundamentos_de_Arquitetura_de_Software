using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Concrete Product
    public class GuinchoMedio : Guincho
    {
        private const Porte PORTE_MEDIO = Porte.Medio;

        public GuinchoMedio() : base(PORTE_MEDIO)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo veículo médio - Modelo: {veiculo.Modelo}");
        }
    }
}

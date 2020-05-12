using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Concrete Product
    public class GuinchoGrande : Guincho
    {
        private const Porte PORTE_GRANDE = Porte.Grande;

        public GuinchoGrande() : base(PORTE_GRANDE)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro grande - Modelo {veiculo.Modelo}");
        }
    }
}

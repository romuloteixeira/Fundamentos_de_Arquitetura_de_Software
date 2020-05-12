using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Concrete Product
    public class GuinchoPequeno : Guincho
    {
        private const Porte PORTE_PEQUENO = Porte.Pequeno;

        public GuinchoPequeno() : base(PORTE_PEQUENO)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo veículo pequeno - Modelo {veiculo.Modelo}");
        }
    }
}

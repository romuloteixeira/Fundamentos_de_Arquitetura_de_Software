using System;

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
        public static Veiculo Criar(string modelo, Porte porte)
        {
            return porte switch
            {
                Porte.Grande => new VeiculoGrande(modelo),
                Porte.Medio => new VeiculoMedio(modelo),
                Porte.Pequeno => new VeiculoPequeno(modelo),
                _ => throw new NotImplementedException("Porte não implementado para veículos.")
            };
        }

        public string Modelo { get; protected set; }
        public Porte Porte { get; protected set; }
    }
}

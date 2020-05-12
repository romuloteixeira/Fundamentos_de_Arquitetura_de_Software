using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class VeiculoCreator
    {
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
    }
}

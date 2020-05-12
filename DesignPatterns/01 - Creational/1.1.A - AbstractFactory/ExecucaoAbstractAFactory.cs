using System.Collections.Generic;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    public abstract class ExecucaoAbstractAFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                Veiculo.Criar("Aris", Porte.Pequeno),
                Veiculo.Criar("308 SW", Porte.Medio),
                Veiculo.Criar("X6", Porte.Grande),
            };

            veiculosSocorro.ForEach(veiculo => AutoSocorro.CriarAutoSocorro(veiculo).RealizarAtendimento());
        }
    }
}

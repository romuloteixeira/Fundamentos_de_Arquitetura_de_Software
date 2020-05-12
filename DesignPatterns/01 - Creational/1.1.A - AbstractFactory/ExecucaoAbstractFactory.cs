using System.Collections.Generic;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    public abstract class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Aris", Porte.Pequeno),
                VeiculoCreator.Criar("308 SW", Porte.Medio),
                VeiculoCreator.Criar("X6", Porte.Grande),
            };

            veiculosSocorro.ForEach(veiculo => AutoSocorro.CriarAutoSocorro(veiculo).RealizarAtendimento());
        }
    }
}

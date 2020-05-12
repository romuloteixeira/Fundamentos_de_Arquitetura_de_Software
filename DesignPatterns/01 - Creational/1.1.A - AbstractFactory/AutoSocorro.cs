using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    // Client Class
    public class AutoSocorro
    {
        private Veiculo veiculo;
        private Guincho guincho;

        public AutoSocorro(AutoSocorroFactory autoSocorroFactory, Veiculo veiculo)
        {
            this.veiculo = autoSocorroFactory.CriarVeiculo(modelo: veiculo.Modelo, porte: veiculo.Porte);
            this.guincho = autoSocorroFactory.CriarGuincho();
        }

        internal void RealizarAtendimento()
        {
            guincho.Socorrer(veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            return veiculo.Porte switch
            {
                Porte.Grande => new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo),
                Porte.Medio => new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo),
                Porte.Pequeno => new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo),
                _ => throw new NotImplementedException("Porte não implemengtado."),
            };
        }
    }
}

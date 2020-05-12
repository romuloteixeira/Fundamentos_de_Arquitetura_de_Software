using System;

namespace DesignPatterns.Creational.AbstractFactory11A
{
    public class GuinchoCreator
    {
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
    }
}

using System;
using OldDragonCharacterCreator.Models;

namespace OldDragonCharacterCreator.Strategies
{
    public class RollInOrderStrategy : IAttributeStrategy
    {
        private Random rnd = new Random();
        private int Roll3d6() => rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);

        public Attributes GenerateAttributes()
        {
            return new Attributos
            {
                Forca = Roll3d6(),
                Destreza = Roll3d6(),
                Constituicao = Roll3d6(),
                Inteligencia = Roll3d6(),
                Sabedoria = Roll3d6(),
                Carisma = Roll3d6()
            };
        }
    }
}
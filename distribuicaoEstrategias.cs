using System;
using System.Collections.Generic;
using System.Linq;
using OldDragonCharacterCreator.Models;

namespace OldDragonCharacterCreator.Strategies
{
    public class RollAndDistributeStrategy : IAttributeStrategy
    {
        private Random rnd = new Random();
        private int Roll3d6() => rnd.Next(1, 7) + rnd.Next(1, 7) + rnd.Next(1, 7);

        public Attributes GenerateAttributes()
        {
            var rolls = new List<int>();
            for (int i = 0; i < 6; i++) rolls.Add(Roll3d6());
            rolls = rolls.OrderByDescending(x => x).ToList();

            return new Attributes
            {
                Forca = rolls[0],
                Constituicao = rolls[1],
                Destreza = rolls[2],
                Sabedoria = rolls[3],
                Inteligencia = rolls[4],
                Carisma = rolls[5]
            };
        }
    }
}
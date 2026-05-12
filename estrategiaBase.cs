using OldDragonCharacterCreator.Models;

namespace OldDragonCharacterCreator.Strategies
{
    public class StandardArrayStrategy : IAttributeStrategy
    {
        public Attributes GenerateAttributes()
        {
            return new Attributes
            {
                Forca = 15,
                Destreza = 14,
                Constituicao = 13,
                Inteligencia = 12,
                Sabedoria = 10,
                Carisma = 8
            };
        }
    }
}
namespace OldDragonCharacterCreator.Models
{
    public abstract class CharacterClass
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract int HitDie { get; }
    }
}
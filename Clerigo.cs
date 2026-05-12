namespace OldDragonCharacterCreator.Models
{
    public class Clerigo : CharacterClass
    {
        public override string Name => "Clérigo";
        public override string Description => "Devotos divinos capazes de curar ferimentos, expulsar mortos-vivos e lutar de forma defensiva.";
        public override int HitDie => 8;
    }
}
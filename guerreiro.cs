namespace OldDragonCharacterCreator.Models
{
    public class Guerreiro : CharacterClass
    {
        public override string Name => "Guerreiro";
        public override string Description => "Mestres do combate, proficientes com todas as armas e armaduras.";
        public override int HitDie => 10;
    }
}
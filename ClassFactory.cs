using System;
using OldDragonCharacterCreator.Models;

namespace OldDragonCharacterCreator.Factories
{
    public static class ClassFactory
    {
        public static CharacterClass CreateClass(string className)
        {
            return className.ToLower() switch
            {
                "guerreiro" => new Guerreiro(),
                "mago" => new Mago(),
                "ladrao" => new Ladrao(),
                _ => throw new ArgumentException("Classe inválida.")
            };
        }
    }
}
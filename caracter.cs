

using System;
using OldDragonCharacterCreator.Strategies;

namespace OldDragonCharacterCreator.Models
{
    public class Character
    {
        public string Name { get; private set; }
        public Attributes Attributes { get; private set; }
        public CharacterClass CharClass { get; private set; }
        public int HitPoints { get; private set; }

        public Character(string name, IAttributeStrategy attributeStrategy, CharacterClass charClass)
        {
            Name = name;
            Attributes = attributeStrategy.GenerateAttributes();
            CharClass = charClass;
            CalculateHitPoints();
        }

        private void CalculateHitPoints()
        {
            int conModifier = Attributes.GetModifier(Attributes.Constituicao);
            int baseHp = CharClass.HitDie + conModifier;
            HitPoints = baseHp < 1 ? 1 : baseHp;
        }

        public void DisplayCharacterSheet()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Classe: {CharClass.Name}");
            Console.WriteLine($"Descrição: {CharClass.Description}");
            Console.WriteLine($"Pontos de Vida (PV): {HitPoints} (Dado: d{CharClass.HitDie} + Mod CON: {Attributes.GetModifier(Attributes.Constituicao)})");
            Console.WriteLine("\nAtributos:");
            Attributes.PrintAttributes();
            Console.WriteLine(new string('-', 40));
        }
    }
}
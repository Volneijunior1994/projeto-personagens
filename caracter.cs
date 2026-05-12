

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
            Attributos = attributeStrategy.GenerateAttributes();
            CharClass = charClass;
            CalcularPontosDeVida();
        }

        private void CalcularPontosDeVida()
        {
            int conModifier = Attributes.GetModifier(Attributos.Constituicao);
            int baseHp = CharClass.PontosDeVida + conModifier;
            PontosDeVida = baseHp < 1 ? 1 : baseHp;
        }

        public void DisplayCharacterSheet()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Classe: {CharClass.Name}");
            Console.WriteLine($"Descrição: {CharClass.Description}");
            Console.WriteLine($"Pontos de Vida (PV): {HitPoints} (Dado: d{CharClass.PontosDeVida} + Mod CON: {Attributes.GetModifier(Attributes.Constituicao)})");
            Console.WriteLine("\nAtributos:");
            Attributes.PrintAttributes();
            Console.WriteLine(new string('-', 40));
        }
    }
}
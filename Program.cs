using System;
using OldDragonCharacterCreator.Models;
using OldDragonCharacterCreator.Strategies;
using OldDragonCharacterCreator.Factories;

namespace OldDragonCharacterCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRIADOR DE PERSONAGENS OLD DRAGON\n");

            var p1 = new Character("Eldor, o Sábio", new RollInOrderStrategy(), ClassFactory.CreateClass("mago"));
            p1.DisplayCharacterSheet();

            var p2 = new Character("Kaelen, Espada Forte", new StandardArrayStrategy(), ClassFactory.CreateClass("guerreiro"));
            p2.DisplayCharacterSheet();

            var p3 = new Character("Lyra, a Sombra", new RollAndDistributeStrategy(), ClassFactory.CreateClass("ladrao"));
            p3.DisplayCharacterSheet();
        }
    }
}
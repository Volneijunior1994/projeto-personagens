using System;

namespace OldDragonCharacterCreator.Models
{
    public class Attributes
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }

        public static int GetModifier(int score)
        {
            if (score <= 3) return -3;
            if (score <= 5) return -2;
            if (score <= 8) return -1;
            if (score <= 12) return 0;
            if (score <= 15) return 1;
            if (score <= 17) return 2;
            return 3;
        }

        public void PrintAttributes()
        {
            Console.WriteLine($"FOR: {Forca} (Mod: {GetModifier(Forca)})");
            Console.WriteLine($"DES: {Destreza} (Mod: {GetModifier(Destreza)})");
            Console.WriteLine($"CON: {Constituicao} (Mod: {GetModifier(Constituicao)})");
            Console.WriteLine($"INT: {Inteligencia} (Mod: {GetModifier(Inteligencia)})");
            Console.WriteLine($"SAB: {Sabedoria} (Mod: {GetModifier(Sabedoria)})");
            Console.WriteLine($"CAR: {Carisma} (Mod: {GetModifier(Carisma)})");
        }
    }
}
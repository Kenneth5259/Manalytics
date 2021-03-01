namespace ManalyticsBackend.Models 
{
    public enum Primaries
    {
        Artifact = 1,
        Conspiracy = 2,
        Creature = 3, 
        Enchantment = 4,
        Instant = 5,
        Land = 6, 
        Phenomenon = 7,
        Plane = 8,
        Planeswalker = 9,
        Scheme = 10,
        Sorcery = 11, 
        Tribal = 12,
        Vanguard = 13
    }

    public class PrimaryType
    {
        public Primaries Type {get; set;}
    }
}
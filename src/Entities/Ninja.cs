namespace RPG_Orientado_Objetos.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int Health, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.Mana = Mana;
        }

        
    }
}
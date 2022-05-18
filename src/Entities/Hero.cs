namespace RPG_Orientado_Objetos.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Health, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Health = Health;
            this.Mana = Mana;

        }
        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;
        public int Health;
        public int Mana;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Health + " " + this.Mana;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }

    }
}
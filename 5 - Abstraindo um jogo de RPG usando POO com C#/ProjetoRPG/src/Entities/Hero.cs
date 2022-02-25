namespace ProjetoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public Hero()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return $@"
            Name: {this.Name}
            Level: {this.Level}
            Hero Type: {this.HeroType}";
        }

        public virtual void Attack()
        {

        }
    }
}
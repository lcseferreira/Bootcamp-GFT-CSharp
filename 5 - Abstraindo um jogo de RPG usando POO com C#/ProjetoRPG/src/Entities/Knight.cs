namespace ProjetoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} atacou usando sua espada.");
        }
    }
}
namespace ProjetoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.Name} atacou usando magia.");
        }

        public void Attack(int bonus)
        {
            if (bonus > 6)
            {
                System.Console.WriteLine($"{this.Name} atacou usando magia com mais força.");
            }
            else
            {
                System.Console.WriteLine($"{this.Name} atacou usando magia com menos força.");
            }


        }
    }
}
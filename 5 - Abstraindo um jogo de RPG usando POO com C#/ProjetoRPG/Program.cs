using ProjetoRPG.src.Entities;

class Program
{
    static void Main()
    {
        var hero = new Knight("Arus", 24, "Knight");
        var wizard = new Wizard("Jennica", 23, "White Wizard");

        Console.WriteLine(hero);
        Console.WriteLine(wizard);

        Console.WriteLine();

        hero.Attack();
        wizard.Attack(7);
    }
}
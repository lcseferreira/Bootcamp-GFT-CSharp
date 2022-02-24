partial class Program
{
    static void Main()
    {
        DemoArrayNome();
    }

    static void DemoArrayNome()
    {
        var nomes = new String[] { "Lucas", "Eduardo", "Lara", "Renata" };

        Console.WriteLine("Digite o nome a ser substituído: ");
        var nome = Console.ReadLine();

        Console.WriteLine("Digite o novo nome: ");
        var nomeNovo = Console.ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        foreach (var item in nomes)
        {
            System.Console.WriteLine(item);
        }

        static void AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }
    }
}
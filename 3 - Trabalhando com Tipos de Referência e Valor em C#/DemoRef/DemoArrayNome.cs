partial class Program
{
    static void DemoArrayNome()
    {
        var nomes = new String[] { "Lucas", "Eduardo", "Lara", "Renata" };

        // Console.WriteLine("Digite o nome a ser substituído: ");
        // var nome = Console.ReadLine();

        // Console.WriteLine("Digite o novo nome: ");
        // var nomeNovo = Console.ReadLine();

        // AlterarNome(nomes, nome, nomeNovo);

        // foreach (var item in nomes)
        // {
        //     System.Console.WriteLine(item);
        // }

        Console.WriteLine("Digite o nome:");
        var nome = Console.ReadLine();

        // Obtendo o valor por referência
        ref var nomeEncontrado = ref LocalizarNome(nomes, nome);

        try
        {
            nomeEncontrado = "Modifiquei por ref";
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

        foreach (var item in nomes)
        {
            Console.WriteLine(item);
        }
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

    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                return ref nomes[i];
            }
        }
        throw new Exception("Nome não encontrado.");
    }
}

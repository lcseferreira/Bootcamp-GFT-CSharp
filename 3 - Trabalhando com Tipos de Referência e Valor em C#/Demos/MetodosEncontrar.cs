using static System.Console;

partial class Program
{

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero) return i;
        }

        return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var p in pessoas)
        {
            if (p == pessoa)
            {
                return true;
            }
        }

        return false;
    }

    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
    {
        foreach (var p in pessoas)
        {
            if (p.Equals(pessoa))
            {
                return true;
            }
        }

        return false;
    }

    static void DemoEncontraNumero()
    {
        var numeros = new int[] { 2, 4, 6, 8 };

        WriteLine("Digite o número que gostaria de encontrar: ");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if (idxEncontrado >= 0)
        {
            WriteLine($"Número {numero} encontrado no índice {idxEncontrado}.");
        }
        else
        {
            WriteLine($"Número não encontrado.");
        }
    }

    static void DemoEncontrarPessoa()
    {
        var pessoas = new List<Pessoa>()
        {
            new Pessoa() {Nome = "Lucas"},
            new Pessoa() {Nome = "Eduardo"},
            new Pessoa() {Nome = "Renata"},
            new Pessoa() {Nome = "Lara"},
        };

        WriteLine("Digite o nome da pessoa:");
        var nome = ReadLine();
        var pessoa = new Pessoa() { Nome = nome };
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        // equals
        if (encontrado)
        {
            WriteLine("A pessoa está na lista.");
        }
        else
        {
            WriteLine("A pessoa não está na lista.");
        }
    }

    static void DemoEncontrarStructPessoa()
    {
        var pessoas = new List<StructPessoa>()
        {
            new StructPessoa() {Nome = "Lucas"},
            new StructPessoa() {Nome = "Eduardo"},
            new StructPessoa() {Nome = "Renata"},
            new StructPessoa() {Nome = "Lara"},
        };

        WriteLine("Digite o nome da pessoa:");
        var nome = ReadLine();
        var pessoa = new StructPessoa() { Nome = nome };
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        // equals
        if (encontrado)
        {
            WriteLine("A pessoa está na lista.");
        }
        else
        {
            WriteLine("A pessoa não está na lista.");
        }
    }
}
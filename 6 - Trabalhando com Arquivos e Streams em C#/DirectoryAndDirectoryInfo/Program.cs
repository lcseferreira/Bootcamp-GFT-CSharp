partial class Program
{
    static void Main()
    {
        CriarDiretorioGlobo();

        Console.WriteLine("Digite o nome do arquivo: ");
        var nomeArquivo = Console.ReadLine();

        CriarArquivo(nomeArquivo);

        var origem = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.txt");
        var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", $"{nomeArquivo}.txt");

        MoverArquivo(origem, destino);

        var destinoCopia = Path.Combine(Environment.CurrentDirectory, "argentina.txt");

        CopiarArquivo(destino, destinoCopia);
    }
}
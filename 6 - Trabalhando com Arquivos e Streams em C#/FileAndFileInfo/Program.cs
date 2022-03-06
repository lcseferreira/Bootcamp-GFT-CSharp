namespace FileAndFileInfo;

partial class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do arquivo: ");
        var nome = Console.ReadLine();

        nome = LimparNome(nome);

        // Caminho do arquivo
        var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
        // var path = Environment.CurrentDirectory + @"\teste.txt";

        CriarArquivo(path);
        Console.WriteLine("Digite enter para finalizar.");
        Console.ReadLine();
    }
}
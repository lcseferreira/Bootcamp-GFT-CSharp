namespace FileAndFileInfo;

partial class Program
{
    static string LimparNome(string nome)
    {
        foreach (var @char in Path.GetInvalidFileNameChars())
        {
            // Vai substituir todos os caracteres inválidos por -
            nome = nome.Replace(@char, '-');
        }

        return nome;
    }
    static void CriarArquivo(string path)
    {
        try
        {
            // Criando um arquivo e usando o using por causa do IDisposable
            using var sw = File.CreateText(path);
            sw.WriteLine("Está é a linha 1 do arquivo");
            // sw.Flush();
            sw.WriteLine("Está é a linha 2 do arquivo");
            // sw.Flush();
        }
        catch
        {
            Console.WriteLine("O nome do arquivo está inválido");
        }
    }

}

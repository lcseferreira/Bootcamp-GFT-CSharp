partial class Program
{
    static void CriarArquivo(string nomeArquivo)
    {
        var path = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.txt");

        if (!File.Exists(path))
        {
            using var sw = File.CreateText(path);
            sw.WriteLine("População: xxMM");
            sw.WriteLine("IDH: x.xxx");
            sw.WriteLine("Dados atualizados em: xx/xx/xxxx");
        }
    }

    static void MoverArquivo(string pathOrigem, string pathDestino)
    {
        if (!File.Exists(pathOrigem))
            throw new IOException("Arquivo de origem não existe.");


        if (File.Exists(pathDestino))
            throw new IOException("Arquivo já existe na pasta de destino.");

        File.Move(pathOrigem, pathDestino);
    }

    static void CopiarArquivo(string pathOrigem, string pathDestino)
    {
        if (!File.Exists(pathOrigem))
            throw new IOException("Arquivo de origem não existe.");


        if (File.Exists(pathDestino))
            throw new IOException("Arquivo já existe na pasta de destino.");

        File.Copy(pathOrigem, pathDestino);
    }
}
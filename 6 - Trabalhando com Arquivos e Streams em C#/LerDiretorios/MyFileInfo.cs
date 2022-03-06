public static class MyFileInfo
{
    public static void LerArquivos(string path)
    {
        if (Directory.Exists(path))
        {
            var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            foreach (var arquivo in arquivos)
            {
                var fileInfo = new FileInfo(arquivo);
                Console.WriteLine($"Nome: {fileInfo.Name}");
                Console.WriteLine($"Tamanho do arquivo: {fileInfo.Length}");
                Console.WriteLine($"Último acesso: {fileInfo.LastAccessTime}");

                Console.WriteLine("----------");
            }
        }
    }

}
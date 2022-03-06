public static class MyDirectoryInfo
{
    public static void LerDiretorios(string path)
    {
        if (Directory.Exists(path))
        {
            var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var dir in diretorios)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"Nome: {dirInfo.Name}");
                Console.WriteLine($"Raiz: {dirInfo.Root}");

                if (dirInfo.Parent != null)
                    Console.WriteLine($"Pai: {dirInfo.Parent.Name}");

                Console.WriteLine("----------");
            }
        }
    }

}
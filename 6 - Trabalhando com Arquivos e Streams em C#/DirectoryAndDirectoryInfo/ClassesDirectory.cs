partial class Program
{
    static void CriarDiretorioGlobo()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "globo");

        if (!Directory.Exists(path))
        {

            // Criando diretório
            var dirGlobo = Directory.CreateDirectory(path);
            // Criando sub diretório
            var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
            var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
            var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

            dirAmNorte.CreateSubdirectory("USA");
            dirAmNorte.CreateSubdirectory("México");
            dirAmNorte.CreateSubdirectory("Canadá");

            dirAmCentral.CreateSubdirectory("Costa Rica");
            dirAmCentral.CreateSubdirectory("Panamá");

            dirAmSul.CreateSubdirectory("Brasil");
            dirAmSul.CreateSubdirectory("Argentina");
            dirAmSul.CreateSubdirectory("Uruguai");
        }
    }
}
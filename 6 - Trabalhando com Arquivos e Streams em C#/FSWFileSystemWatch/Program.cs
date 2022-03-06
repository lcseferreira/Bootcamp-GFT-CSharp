using static System.Console;

var path = @"C:\Users\lcsef\Documents\Workspaces\bootcamp-gft-dotnet\6 - Trabalhando com Arquivos e Streams em C#\DirectoryAndDirectoryInfo\globo";

// O FSW vai monitorar tudo que acontecer na nossa path
using var fsw = new FileSystemWatcher(path);

fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;
fsw.Created += OnCreated;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

WriteLine("Pressione [enter] para finalizar.");
ReadLine();

void OnDeleted(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi excluído o arquivo {e.Name} na past {e.FullPath}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    WriteLine($"Foi renomeado o arquivo {e.OldName} para {e.Name} na pasta {e.FullPath}");
}

void OnCreated(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi criado o arquivo {e.Name} na past {e.FullPath}");
}
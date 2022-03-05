// Caminho do arquivo
var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");
// var path = Environment.CurrentDirectory + @"\teste.txt";

// Criando um arquivo e usando o using por causa do IDisposable
using var sw = File.CreateText(path);
sw.WriteLine("Está é a linha 1 do arquivo");
// sw.Flush();
sw.WriteLine("Está é a linha 2 do arquivo");
// sw.Flush();

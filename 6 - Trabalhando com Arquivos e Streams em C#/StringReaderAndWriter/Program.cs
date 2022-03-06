using System.Text;

// 
var sb = new StringBuilder();
sb.AppendLine("Primeira linha");
sb.AppendLine("Segunda linha");
sb.AppendLine("Terceira linha");

using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;

// do
// {
//     buffer = new char[10];
//     tamanho = sr.Read(buffer);
//     Console.Write(string.Join("", buffer));
// } while (tamanho >= buffer.Length);

do
{
    Console.WriteLine(sr.ReadLine());
} while (sr.Peek() >= 0);
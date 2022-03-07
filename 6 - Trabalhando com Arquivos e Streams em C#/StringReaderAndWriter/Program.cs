using System.Text;

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

Console.WriteLine();

string textReaderText = "StringBuilder() - disponível no System-Text, como o nome diz é uma classe que construtora de strings dentro de uma instância de StringBuilder Para pegarmos a string que está dentro dessa instância, usamos o método ToString().\n" +
                        "StringReader() - pode ser utilizado para ler uma string builder, Implementa a interface IDisposable, ou seja, devemos usar com a diretiva using para quando terminar o método, descarregar automaticamente o que está na memória.";

string linha, paragrafo = null;
var newSr = new StringReader(textReaderText);


while (true)
{
    linha = newSr.ReadLine();

    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;
    }
}

Console.WriteLine($"Texto modificado: \n{paragrafo}");

int charLido;
char charConvertido;

var sw = new StringWriter();
newSr = new StringReader(paragrafo);

while (true)
{
    charLido = newSr.Read();

    if (charLido == -1) break;

    charConvertido = Convert.ToChar(charLido);

    if (charConvertido == '.')
    {
        sw.Write(".\n\n");

        newSr.Read();
    }
    else
    {
        sw.Write(charConvertido);
    }
}

Console.WriteLine($"Texto modificado pelo StringWriter: \n{sw.ToString()}");
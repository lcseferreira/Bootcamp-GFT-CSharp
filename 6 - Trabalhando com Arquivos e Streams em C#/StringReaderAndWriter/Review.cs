using System.Text;

partial class Program
{
    static void Review()
    {
        // Construtor de string
        var sb = new StringBuilder();
        sb.AppendLine("Olá, está é uma linha!"); // Adicionando uma linha
        sb.Replace("!", "!!!"); // Fazendo replace no meu sw

        // Leitor de StringBuilder
        using var sr = new StringReader(sb.ToString());

        do
        {
            Console.WriteLine(sr.ReadToEnd());
        } while (sr.Peek() >= 0);

        Console.WriteLine();

        var text = "Stream é uma classe abstrata que fornece uma visão genérica de uma sequência de bytes.\n\n" +
        "Existe uma grande vantagem de se utilizar Streams, pois os dados são escritos, lidos, ou modificados através de um Buffer.\n\n" +
        "Buffer é uma espécie de reservatório onde podemos armazenar uma grande quantidade de dados em pequenos pedaços, o famoso dividir para conquistar.\n\n";

        var newSR = new StringReader(text);

        Console.WriteLine();

        string linha, paragrafo = null;

        while (true)
        {
            linha = newSR.ReadLine();

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

        Console.WriteLine(paragrafo);

        Console.WriteLine();

        int charLido;
        char charConvertido;

        var sw = new StringWriter();
        newSR = new StringReader(paragrafo);

        while (true)
        {
            // Ler char por char
            charLido = newSR.Read();

            // Se não houver mais char para ler, pare
            if (charLido == -1) break;

            charConvertido = Convert.ToChar(charLido);

            // Se o char for um ponto...
            if (charConvertido == '.')
            {

                sw.Write(".\n\n");

                newSR.Read();
                newSR.Read();
            }
            else
            {
                sw.Write(charConvertido);
            }
        }

        Console.WriteLine(sw.ToString());
    }
}
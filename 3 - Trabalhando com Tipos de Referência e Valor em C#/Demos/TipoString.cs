using static System.Console;

partial class Program
{
    static void MudarNomePessoa(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void DemoString()
    {
        string nome = "Lucas";

        MudarNomePessoa(nome, "Lucas Eduardo");

        WriteLine(nome);
    }
}
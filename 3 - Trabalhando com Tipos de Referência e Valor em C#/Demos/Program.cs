using static System.Console;

partial class Program
{
    static void Main()
    {
        var structPessoa1 = new StructPessoa()
        {
            Nome = "Lucas",
            Idade = 24,
            Documento = "3213214"
        };

        var structPessoa2 = structPessoa1;

        WriteLine($@"
        Nome da pessoa1: {structPessoa1.Nome}
        Nome da pessoa2: {structPessoa2.Nome}
        ");

        structPessoa2.Nome = "Lucas Eduardo Ferreira da Rosa";

        WriteLine($@"
        Nome da pessoa1: {structPessoa1.Nome}
        Nome da pessoa2: {structPessoa2.Nome}
        ");
    }
}
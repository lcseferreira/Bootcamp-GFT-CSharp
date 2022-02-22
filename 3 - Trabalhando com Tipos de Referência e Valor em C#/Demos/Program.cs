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

        // Não irá funcionar, pois structs ficam na stack
        var structPessoa2 = structPessoa1;

        WriteLine($@"
        Nome da pessoa1: {structPessoa1.Nome}
        Nome da pessoa2: {structPessoa2.Nome}
        ");

        // Vai trocar somente a structPessoa1, pois é uma cópia do tipo valor
        MudarNomePessoa(structPessoa1, "Luquinha");

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
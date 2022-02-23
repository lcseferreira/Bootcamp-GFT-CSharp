using static System.Console;

partial class Program
{
    static void Adicionar20(int a)
    {
        a += 20;
    }

    static int Adicionar30(int x)
    {
        return x + 30;
    }

    static void DemoValor()
    {
        // Value Type int - cópia por valor (alocação na stack)
        int a = 2;
        Adicionar20(a);

        WriteLine($"O valor da variável a é {a}");

        // Atribuindo outro valor para a variável a
        a = Adicionar30(a);

        WriteLine($"O valor da variável a é {a}");
    }

    static void MudarNomePessoa(StructPessoa p1, string nome)
    {
        p1.Nome = nome;
    }

    static void DemoStruct()
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
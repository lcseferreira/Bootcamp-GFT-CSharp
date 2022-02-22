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
}
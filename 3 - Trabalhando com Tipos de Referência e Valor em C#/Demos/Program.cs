using static System.Console;

partial class Program
{
    static void Main()
    {
        // Value Type int - cópia por valor (alocação na stack)
        int a = 2;
        Adicionar20(a);

        WriteLine($"O valor da variável a é {a}");

        // Atribuindo outro valor para a variável a
        a = Adicionar30(a);

        WriteLine($"O valor da variável a é {a}");
    }
}
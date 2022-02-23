using static System.Console;

partial class Program
{
    static void Main()
    {
        int[] pares = { 0, 2, 4, 6, 8 };

        MudarParImpar(pares);

        foreach (var n in pares) { WriteLine(n); }
        WriteLine($"{ string.Join(',', pares)}");
    }
}
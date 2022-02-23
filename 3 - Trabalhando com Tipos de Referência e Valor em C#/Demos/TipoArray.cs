using static System.Console;

partial class Program
{

    static void MudarParImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] += 1;
        }
    }

    static void DemoArray()
    {
        int[] pares = { 0, 2, 4, 6, 8 };

        MudarParImpar(pares);

        foreach (var n in pares) { WriteLine(n); }
        WriteLine($"{ string.Join(',', pares)}");
    }
}
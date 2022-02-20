namespace Instrucoes;

partial class Program
{

    static void ArrayUnidimensional()
    {
        int[] arrayUni = new int[10];

        for (int i = 0; i < arrayUni.Length; i++)
        {
            arrayUni[i] = i * 2;
        }

        foreach (var numero in arrayUni)
        {
            Console.WriteLine($"Número: {numero}");
        }
    }

    static void ArrayMultidimensional()
    {
        int[,] arrayMulti = new int[10, 5];
        int[,,] arrayMulti = new int[10, 5, 10];
    }
}
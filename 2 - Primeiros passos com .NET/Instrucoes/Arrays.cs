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
}